using SimpleTcp;
using System.Text;
namespace TCPClient
{
    public partial class FormClient : Form
    {
        string exitMessage = "Do you really want to exit?";
        public FormClient()
        {
            InitializeComponent();
        }

        SimpleTcpClient client;

        private void FormClient_Load(object sender, EventArgs e)
        {
            client = new(txtIP.Text);
            client.Events.Connected += Events_Connected; ;
            client.Events.Disconnected += Events_Disconnected; ;
            client.Events.DataReceived += Events_DataReceived;
            btnSend.Enabled = false;
        }
        private void Events_Connected(object? sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtInfo.Text += $"Server connected.{Environment.NewLine}";
            });
        }

        private void Events_Disconnected(object? sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtInfo.Text += $"Server disconnected.{Environment.NewLine}";
            });
        }
        private void Events_DataReceived(object? sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtInfo.Text += $"Server: {Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";
            });
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                client.Connect();
                btnSend.Enabled = true;
                btnConnect.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (client.IsConnected)
            {
                if(!string.IsNullOrEmpty(txtMessage.Text))
                {
                    client.Send(txtMessage.Text);
                    txtInfo.Text += $"Me: {txtMessage.Text}{Environment.NewLine}";
                    txtMessage.Text = String.Empty;
                }
            
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(exitMessage, "Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
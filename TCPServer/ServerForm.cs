using SimpleTcp;
using System.Text;
using System.Windows;
namespace TCPServer
{
    public partial class FormServer : Form
    {
        string exitMessage = "Do you really want to exit?";
        int blink1;
        int blink2;
        public FormServer()
        {
            InitializeComponent();
        }

        SimpleTcpServer server;

        private void FormServer_Load(object sender, EventArgs e)
        {
            btnSend.Enabled = false;
            server = new SimpleTcpServer(txtIP.Text);
            server.Events.ClientConnected += Events_ClientConnected;
            server.Events.ClientDisconnected += Events_ClientDisconnected;
            server.Events.ClientConnected += Events_ClientConnected;
            server.Events.DataReceived += Events_DataReceived;

        }
        private void Events_DataReceived(object? sender, DataReceivedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtInfo.Text += $"{e.IpPort}: {Encoding.UTF8.GetString(e.Data)}{Environment.NewLine}";
            });
        }

        private void Events_ClientDisconnected(object? sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                txtInfo.Text += $"{e.IpPort} disconnected.{Environment.NewLine}";
                boxClientIP.Items.Remove(e.IpPort);
            });
        }

        private void Events_ClientConnected(object? sender, ConnectionEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
           {
               txtInfo.Text += $"{e.IpPort} connected.{Environment.NewLine}";
               boxClientIP.Items.Add(e.IpPort);
           });
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            server.Start();
            txtInfo.Text += $"Starting...{Environment.NewLine}";
            btnStart.Enabled = false;
            btnClose.Enabled = true;
            btnSend.Enabled = true;

            Thread thr1 = new Thread(Blink);
            thr1.Start();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (server.IsListening) //ako server "slusa"
            {
                if(!string.IsNullOrEmpty(txtMessage.Text) && boxClientIP.SelectedItem != null) //ako nema texta i ako nije odabran klijent
                {
                    server.Send(boxClientIP.SelectedItem.ToString(), txtMessage.Text); //onda odaberi klijenta
                    txtInfo.Text += $"Server: {txtMessage.Text}{Environment.NewLine}"; //prikazi poslanu poruku servera na serveru 
                    txtMessage.Text = String.Empty; //read-only
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(exitMessage, "Exit", MessageBoxButtons.YesNo); //poruka o potvrdi zatvaranja servera
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private async void Blink()
        {
            while (true)
            {
                await Task.Delay(1000);
                lblStatus.BackColor = lblStatus.BackColor == Color.Green ? Color.YellowGreen : Color.Green;
            }
        }
    }
}

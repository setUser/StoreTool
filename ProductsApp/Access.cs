using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace ProductsApp
{
    public partial class Access : Form
    {
        private string _servername;
        private string _username;
        private string _password;
        private string _connectionString;
        private const string _dbname = "DB_ElPancito";
        private const string _TableName = "Productos_ElPancito";
        private const string _PrimaryKeyName = "CodigoProducto";
        private const string _TimeStampName = "UltimaModificacionProducto";
        private DBConnection _DBConnection;
        public Access()
        {
            InitializeComponent();
        }

        private void IngressButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader file = new StreamReader("host.data"))
                {
                    _servername = file.ReadLine();
                    file.Close();
                }
                _username = UserTextBox.Text;
                _password = PasswordTexBox.Text;
                _connectionString = $"Server = {_servername}; Database = {_dbname}; Uid = {_username}; Pwd ={_password};";
                _DBConnection = new DBConnection(_connectionString, _TableName, _PrimaryKeyName, _TimeStampName);
                int test = _DBConnection.Count;
                if (test == -1)
                {
                    throw new Exception();
                }
                this.Close();
                Thread thread = new Thread(StartCRUD);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Usuario y/o Contraseña Incorectos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void StartCRUD()
        {
            Application.Run(new CRUDapps(_DBConnection));
        }
        private void UserTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                IngressButton_Click(null, null);
            }
        }

        private void CloseApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

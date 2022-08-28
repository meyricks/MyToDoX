namespace ToDoList
{
	public partial class Form1 : Form
	{

		DataSet1TableAdapters.UsuarioTableAdapter DB;
		int IdUsuario;
		public Form1()
		{
			InitializeComponent();
			DB = new DataSet1TableAdapters.UsuarioTableAdapter();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			ValidarUsuario();
		}

		private void ValidarUsuario()
		{
			if (textBox1.Text != "Usuario" && textBox2.Text != "Clave")
			{
				IdUsuario = Convert.ToInt32(DB.GetUsuario(textBox1.Text, textBox2.Text));
				if (IdUsuario != 0)
				{
					var x = ToDoList.GetInstance();
					x.IdUser = IdUsuario;
					x.UserName = textBox1.Text;
					x.ShowDialog();
					this.Close();
				}
				else
				{
					MessageBox.Show("Usuario o clave incorrecta");
				}
			}
			else
			{
				MessageBox.Show("Llene los campos correspondientes");
			}
		}

		private void Form1_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_Click(object sender, EventArgs e)
		{
	
		}

		private void textBox1_Leave(object sender, EventArgs e)
		{

			
		}

		private void textBox2_Click(object sender, EventArgs e)
		{

		}

		private void textBox2_Leave(object sender, EventArgs e)
		{
		
		
	}

		private void textBox2_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{ 
				ValidarUsuario();
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
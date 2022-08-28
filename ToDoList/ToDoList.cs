using CodeMax_POS;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
	public partial class ToDoList : Form
	{
		DataSet1TableAdapters.UsuarioTableAdapter DB;
		DataSet1TableAdapters.ListEncabezadoTableAdapter DBList;
		public string UserName;
		public int IdUser;
		public static ToDoList Instancia = null;
		// GVP.Metodos GVP;
		public static ToDoList GetInstance()
		{
			if (Instancia == null)
			{
				Instancia = new ToDoList();
			}

			return Instancia;
		}
		public ToDoList()
		{
			InitializeComponent();
			DB = new DataSet1TableAdapters.UsuarioTableAdapter();
			DBList = new DataSet1TableAdapters.ListEncabezadoTableAdapter();
			
		}
		private void button2_Click(object sender, EventArgs e)
		{
			string Division = sender.ToString();
			string[] arrayDivision = Division.Split('*');
			string nombre = arrayDivision[1];
			string Id = arrayDivision[2];
			var x = ListDetalle.GetInstance();
			x.richTextBox1.Text = nombre;
			x.button1.Text = "Editar";
			x.IdLists = Convert.ToInt32(Id);
			x.ShowDialog();

		}
		public void TraerProductos()
		{
			try
			{
				int[] IdList = new int[1000];
		
				dataGridView2.DataSource = DBList.GetDataByUsuario(Convert.ToInt32(IdUser));
				panel1.Controls.Clear();
				var lista = new ArrayList();
				string[] Array = new string[1000];

				for (int i = 0; i < dataGridView2.RowCount; i++)
				{
					Array[i] = dataGridView2.Rows[i].Cells[0].Value.ToString();
					lista.Add(Array[i]);
					//    IdProducto[i] = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
				}



				Button[] btn = new Button[lista.Count];
			
				int xPos = 20;
				int yPos = 0;
				int cambiarposicion = 4;
				Font f = new Font("Verdana", float.Parse("8"), FontStyle.Bold);
				Font f2 = new Font("Times New Roman", float.Parse("1"), FontStyle.Bold | FontStyle.Underline);
				int conteofilas = 1;

				for (int i = 0; i < lista.Count; i++)
				{

					btn[i] = new Button();
					btn[i].Size = new Size(130, 100);
					btn[i].Text =  " * " + dataGridView2.Rows[i].Cells[2].Value.ToString() + " * " + dataGridView2.Rows[i].Cells[0].Value.ToString();
					btn[i].TextAlign = ContentAlignment.BottomCenter;
					btn[i].ForeColor = Color.Black;
					
					btn[i].Font = f;
					btn[i].Name = dataGridView2.Rows[i].Cells[0].Value.ToString() + " * " + dataGridView2.Rows[i].Cells[2].Value.ToString();
					btn[i].TextAlign = ContentAlignment.MiddleCenter;
					btn[i].SendToBack();
					btn[i].Click += new EventHandler(button2_Click);




					if (i > 0)
					{
						if (i == 8)
						{

						}
						if (i == cambiarposicion)
						{
							conteofilas = 1 + conteofilas;
							cambiarposicion = cambiarposicion + 4;

							double a = (i / 4);

							int y = Convert.ToInt32(a);

							double b = a - y;

							if (b == 0)
							{
								xPos = +20;
							}
							else
							{
								xPos = +170;
							}


							yPos = yPos + 160;
						}
						else if (i == (cambiarposicion + 1))
						{

						}
						else
						{

							xPos = xPos + 170;
							yPos = yPos + 0;



						}
						/* else if (i == (cambiarposicion+1))
                         {
                             cambiarposicion = cambiarposicion + 6;
                             xPos = 0;
                             yPos = yPos + 120;
                         }*/
					}

					// Location of button:
					


					btn[i].Left = xPos;
					btn[i].Top = yPos;
		
					panel1.Controls.Add(btn[i]);
				
				}
			}
			catch(Exception)
			{

			}





		}
		private void ToDoList_Load(object sender, EventArgs e)
		{
			label2.Text = UserName;
			TraerProductos();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string value = "";
			if (InputBox.Text("Lista", "Digite lel nombre de la lista", ref value) == DialogResult.OK)
			{
				DBList.InsertQuery(IdUser, value, DateTime.Now.ToShortTimeString());
				TraerProductos();
			}

		}
	}
}

using CodeMax_POS;
using Microsoft.VisualBasic.ApplicationServices;
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
	public partial class ListDetalle : Form
	{
		DataSet1TableAdapters.ListDetalleTableAdapter DBList;
		DataSet1TableAdapters.ListEncabezadoTableAdapter DBListE;
		public int IdLists;
		public static ListDetalle Instancia = null;
		// GVP.Metodos GVP;
		public static ListDetalle GetInstance()
		{
			if (Instancia == null)
			{
				Instancia = new ListDetalle();
			}

			return Instancia;
		}
		public ListDetalle()
		{
			InitializeComponent();
			DBList = new DataSet1TableAdapters.ListDetalleTableAdapter();
			DBListE = new DataSet1TableAdapters.ListEncabezadoTableAdapter();
		}

		private void ListDetalle_Load(object sender, EventArgs e)
		{
			TraerProductos();
		}

		private void TraerProductos()
		{
			try
			{
				int[] IdList = new int[1000];

				dataGridView2.DataSource = DBList.GetDataByLista(IdLists);
				panel1.Controls.Clear();
				var lista = new ArrayList();
				string[] Array = new string[1000];

				for (int i = 0; i < dataGridView2.RowCount; i++)
				{
					Array[i] = dataGridView2.Rows[i].Cells[0].Value.ToString();
					lista.Add(Array[i]);
					//    IdProducto[i] = Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
				}



				CheckBox[] btn = new CheckBox[lista.Count];

				int xPos = 20;
				int yPos = 0;
				int cambiarposicion = 4;
				Font f = new Font("Verdana", float.Parse("11"), FontStyle.Bold);
				Font f2 = new Font("Verdana", float.Parse("11"), FontStyle.Bold | FontStyle.Strikeout);
				int conteofilas = 1;

				for (int i = 0; i < lista.Count; i++)
				{

					btn[i] = new CheckBox();
					btn[i].Size = new Size(130, 100);
					btn[i].Text =  dataGridView2.Rows[i].Cells[2].Value.ToString();
					btn[i].TextAlign = ContentAlignment.BottomCenter;
					btn[i].ForeColor = Color.Black;
		
				
					btn[i].Name = dataGridView2.Rows[i].Cells[0].Value.ToString() + " * " + dataGridView2.Rows[i].Cells[2].Value.ToString();
					btn[i].TextAlign = ContentAlignment.MiddleCenter;
					btn[i].SendToBack();
					btn[i].Checked = Convert.ToBoolean(dataGridView2.Rows[i].Cells[3].Value);
					btn[i].CheckedChanged += new EventHandler(checkBox1_CheckedChanged);
					btn[i].MouseDown += new MouseEventHandler(checkBox1_MouseDown);
					if (Convert.ToBoolean(dataGridView2.Rows[i].Cells[3].Value) == true)
					{
						btn[i].Font = f2;
					}
					else
					{
						btn[i].Font = f;
					}
					


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
			catch (Exception)
			{

			}





		}
	
		private void button2_Click(object sender, EventArgs e)
		{
			string value = "";
			if (InputBox.Text("Tarea", "Digite lel nombre de la tarea", ref value) == DialogResult.OK)
			{
				DBList.InsertQuery(IdLists, value, false, DateTime.Now.ToShortTimeString());
				TraerProductos();
			}
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				var x = sender;
				string nombre = ((System.Windows.Forms.ButtonBase)x).Text;
				string dividir = sender.ToString().Replace("System.Windows.Forms.CheckBox, CheckState: ", "");
				int ValorNum = Convert.ToInt32(dividir);
				bool Valor = Convert.ToBoolean(ValorNum);
				int? IdListDetalle = DBList.GetId(nombre, IdLists);
				DBList.UpdateValor(Valor, Convert.ToInt32(IdListDetalle));
				TraerProductos();
			}
			catch (Exception)
			{

				throw;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				DBListE.UpdateDescripcion(richTextBox1.Text, IdLists);
				MessageBox.Show("Modificado con exito");
			}
			catch (Exception)
			{

				throw;
			}
		}

		private void ListDetalle_FormClosed(object sender, FormClosedEventArgs e)
		{
			var z = ToDoList.GetInstance();
			z.TraerProductos();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			try
			{
				DBList.DeleteByEncabezado(IdLists);
				DBListE.DeleteQuery(IdLists);
				
				MessageBox.Show("Eliminado con exito");
				this.Close();
			
			}
			catch (Exception)
			{

				throw;
			}
		}

	
		private void checkBox1_Click(object sender, EventArgs e)
		{
			

		}

		private void checkBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			
		}

		private void checkBox1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.M)
			{

			
				
			}
		}

		private void checkBox1_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				var x = sender;
				string nombre = ((System.Windows.Forms.ButtonBase)x).Text;
				string dividir = sender.ToString().Replace("System.Windows.Forms.CheckBox, CheckState: ", "");
				int ValorNum = Convert.ToInt32(dividir);
				bool Valor = Convert.ToBoolean(ValorNum);
				int? IdListDetalle = DBList.GetId(nombre, IdLists);
				string value = "";
				DialogResult dialogResult = MessageBox.Show("Presione si para editar o presione no para eliminar", " "+ nombre, MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.Yes)
				{
					if (InputBox.Text("Tarea", "Digite lel nombre de la tarea", ref value) == DialogResult.OK)
					{
						DBList.UpdateQuery(IdLists, value, Valor, DateTime.Now.ToShortTimeString(), Convert.ToInt32(IdListDetalle));
						MessageBox.Show("Modificado con exito");
						TraerProductos();
					}
				}
				else if (dialogResult == DialogResult.No)
				{

					if (MessageBox.Show("Seguro que desa elminar la tarea ", " " + nombre, MessageBoxButtons.YesNo) == DialogResult.Yes)
					{
						DBList.DeleteQuery(Convert.ToInt32(IdListDetalle));
						MessageBox.Show("Eliminado con exito");
						TraerProductos();
					}
				}
				
			}
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Npgsql;
using System.Data;

namespace DogDB
{
	public partial class index : System.Web.UI.Page
	{
		private DataSet ds = new DataSet();
		private DataTable dt = new DataTable();

		protected void Page_Load(object sender, EventArgs e)
		{

			try
			{
				Label1.Text = "Connection success";

				NpgsqlConnection conn = new NpgsqlConnection("Server=192.168.1.107;Port=5432;Database=tjta3501;User Id=elsi;Password=sitäkissaostaisi;");
				conn.Open();

				NpgsqlCommand comm = new NpgsqlCommand();
				comm.Connection = conn;
				comm.CommandType = CommandType.Text;
				comm.CommandText = "SELECT * FROM public.\"Dog\" ORDER BY bday DESC";


				if (Text1search.Text.Length >= 2)
                {
					if (DropDowntList1.SelectedItem.Value == "name")
					{
						comm.CommandText = "SELECT * FROM public.\"Dog\" WHERE name like'%" + Text1search.Text + "%' ORDER BY name ASC";
					}

					if (DropDowntList1.SelectedItem.Value == "dog_id")
					{
						comm.CommandText = "SELECT * FROM public.\"Dog\" WHERE dog_id like'%" + Text1search.Text + "%' ORDER BY bday DESC";
					}

					if (DropDowntList1.SelectedItem.Value == "gender")
					{
						comm.CommandText = "SELECT * FROM public.\"Dog\" WHERE gender like'%" + Text1search.Text + "%' ORDER BY bday DESC";
					}

					if (DropDowntList1.SelectedItem.Value == "owner_id")
					{
						comm.CommandText = "SELECT * FROM public.\"Dog\" WHERE owner_id ::text like'%" + Text1search.Text + "%' ORDER BY owner_id ASC";
					}

					if (DropDowntList1.SelectedItem.Value == "user_id")
					{
						comm.CommandText = "SELECT * FROM public.\"User\" WHERE owner_id ::text like'%" + Text1search.Text + "%' ORDER BY owner_id ASC";
					}

					if (DropDowntList1.SelectedItem.Value == "username")
					{
						comm.CommandText = "SELECT * FROM public.\"User\" WHERE name like'%" + Text1search.Text + "%' ORDER BY name ASC";
					}
				}

				if (TextBox5.Text.Length >= 6)
				{
					NpgsqlCommand del = new NpgsqlCommand("DELETE FROM public.\"Dog\" WHERE dog_id like'%" + TextBox5.Text + "%'", conn);
					del.ExecuteNonQuery();

					TextBox5.Text = string.Empty;
				}

				if (TextBox1.Text.Length > 3 & TextBox3.Text.Length > 6 & TextBox4.Text.Length > 0) 
				{
					long id = 10000000000;
					Random random = new Random();
					int num = random.Next(100000000, 999999999);
					id += num;
					
					NpgsqlCommand cmd = new NpgsqlCommand("insert into public.\"Dog\" values('"+ id + "', '" + TextBox1.Text + "', '" + RadioButtonList1.SelectedValue + "', '" + TextBox3.Text + "', '" + TextBox4.Text + "')", conn);
					cmd.ExecuteNonQuery();

					TextBox1.Text = string.Empty;
					TextBox3.Text = string.Empty;
					TextBox4.Text = string.Empty;
				}

				NpgsqlDataAdapter da = new NpgsqlDataAdapter(comm);

				da.Fill(dt);
				comm.Dispose();
				conn.Close();

				GridView1.DataSource = dt;
				GridView1.DataBind();
				
			}
			catch (Exception)
			{
				Label1.Text = "Something gone wrong...";
				throw;
			}
		}
	}
}
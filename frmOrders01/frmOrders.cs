using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmOrders01
{
    public partial class frmOrders : Form
    {
        string conString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
        string vsSQLCommand = "";
        string vsSQLCommandCombo = "";
        string vsSQLQuery = "";
        public frmOrders()
        {
            InitializeComponent();
        }

        private void frmOrders_Load(object sender, EventArgs e)
        {

            vsSQLCommand = "SELECT OrderID,Customers.CompanyName, CONCAT(Employees.FirstName,' ',Employees.LastName) AS 'Employee',Shippers.CompanyName AS 'Shipper Company' FROM Orders ";
            vsSQLCommand += "INNER JOIN Customers ON Orders.CustomerID=Customers.CustomerID ";
            vsSQLCommand += "INNER JOIN Employees ON Orders.EmployeeID=Employees.EmployeeID ";
            vsSQLCommand += "INNER JOIN Shippers ON Orders.ShipVia=Shippers.ShipperID ";
            vsSQLCommand += "WHERE Shippers.ShipperID > 0 ";

            PrepareGrid();
            BindGrid(vsSQLCommand);
            GetEmployee();
            GetShipper();

        }
        private void PrepareGrid()
        {
            dgvOrders.AutoGenerateColumns = true;  // grid kolonlarını oluşturma
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            

            
            dgvOrders.ReadOnly = true;

            dgvOrders.AllowUserToResizeRows = false;

            dgvOrders.RowHeadersVisible = false;

        }

        

        private void BindGrid(string prmSQLText) 
        {
            using (SqlConnection con = new SqlConnection(conString)) // db ye bağlanma
            {
                
                using (SqlCommand cmd = new SqlCommand(prmSQLText,con))
                {
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataSet dSet = new DataSet())
                        {
                            sda.Fill(dSet);
                            dgvOrders.DataSource= dSet.Tables[0];

                            
                            
                        }
                    }
                }
            }

        }

        private void GetEmployee()
        {
            using(SqlConnection con = new SqlConnection(conString))
            {
                vsSQLCommandCombo = "SELECT EmployeeID,CONCAT(FirstName,' ',LastName) AS 'Employee' FROM Employees";
                using(SqlCommand cmd = new SqlCommand(vsSQLCommandCombo, con))
                {
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataSet dSet = new DataSet())
                        {
                            sda.Fill(dSet);

                            DataRow newRow = dSet.Tables[0].NewRow();
                            newRow["EmployeeID"] = 0;
                            newRow["Employee"] = "Seçiniz";
                            dSet.Tables[0].Rows.InsertAt(newRow, 0);

                            cboxEmployee.DataSource = dSet.Tables[0];
                            cboxEmployee.ValueMember = "EmployeeID";
                            cboxEmployee.DisplayMember = "Employee";
                        }

                    }

                }
            }
        }

        
        private void GetShipper()
        {
            using (SqlConnection con = new SqlConnection(conString)) 
            {
                vsSQLCommandCombo = "SELECT ShipperID,CompanyName FROM Shippers";

                using (SqlCommand cmd=new SqlCommand(vsSQLCommandCombo,con))
                {
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataSet dSet = new DataSet()) 
                        {
                            sda.Fill(dSet);

                            DataRow newRow = dSet.Tables[0].NewRow();
                            newRow["ShipperID"] = 0;
                            newRow["CompanyName"] = "Seçiniz";
                            dSet.Tables[0].Rows.InsertAt(newRow, 0);

                            cboxShipVia.DataSource = dSet.Tables[0];
                            cboxShipVia.ValueMember = "ShipperID";
                            cboxShipVia.DisplayMember = "CompanyName";

                            
                        }

                    }
                }

                

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            vsSQLQuery = "";
            if (cboxEmployee.SelectedIndex>0) 
            {
                vsSQLQuery += "AND Employees.EmployeeID =" + cboxEmployee.SelectedValue;
            }

            if(cboxShipVia.SelectedIndex>0)
            {
                vsSQLQuery += "AND Shippers.ShipperID = "+cboxShipVia.SelectedValue;
            }
            BindGrid(vsSQLCommand + vsSQLQuery);
        }

        private void frmOrders_AutoSizeChanged(object sender, EventArgs e)
        {

        }

        private void grpboxOrders_AutoSizeChanged(object sender, EventArgs e)
        {
            
        }
    }
}

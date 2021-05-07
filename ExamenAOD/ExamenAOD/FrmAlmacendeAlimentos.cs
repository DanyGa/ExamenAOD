using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xls = Microsoft.Office.Interop.Excel;

namespace ExamenAOD
{
    public partial class FrmAlmacendeAlimentos : Form
    {
        public FrmAlmacendeAlimentos()
        {
            InitializeComponent();
        }

        xls.Application a = new xls.Application();
        int i = 5;

        private void FrmAlmacendeAlimentos_Load(object sender, EventArgs e)
        {
            a.Workbooks.Open(Application.StartupPath + @"\ArchivoExamen.xlsx");
            while (a.ActiveWorkbook.ActiveSheet.Cells(i, 1).Value != null)
            {
                i++;
            }
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            lvProductos.Items.Clear();
            int x = 5;
            while (a.ActiveWorkbook.ActiveSheet.Cells(x, 1).Value != null)
            {
                string id = a.ActiveWorkbook.ActiveSheet.Cells(x, 1).Value.ToString();
                string nombre = a.ActiveWorkbook.ActiveSheet.Cells(x, 2).Value.ToString();
                string precio = a.ActiveWorkbook.ActiveSheet.Cells(x, 3).Value.ToString();
                string existencia = a.ActiveWorkbook.ActiveSheet.Cells(x, 4).Value.ToString();
                string medida = a.ActiveWorkbook.ActiveSheet.Cells(x, 5).Value.ToString();
                string fecha = a.ActiveWorkbook.ActiveSheet.Cells(x, 6).Value.ToString();
                string proveedor = a.ActiveWorkbook.ActiveSheet.Cells(x, 7).Value.ToString();
                ListViewItem lista = new ListViewItem(id);
                lista.SubItems.Add(nombre);
                lista.SubItems.Add(precio);
                lista.SubItems.Add(existencia);
                lista.SubItems.Add(medida);
                lista.SubItems.Add(fecha);
                lista.SubItems.Add(proveedor);
                lvProductos.Items.Add(lista);
                x++;
            }
        }

        private void btnEscribir_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string nombre = txtNombre.Text;
            string precio = txtPrecio.Text;
            string existencia = txtExistencia.Text;
            string medida = txtMedida.Text;
            string fecha = txtFecha.Text;
            string proveedor = cbProveedor.Text;
            txtId.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtExistencia.Clear();
            txtMedida.Clear();
            txtFecha.Clear();
            cbProveedor.ResetText();

            a.ActiveWorkbook.Worksheets[1].Cells(i, 1).Value = id;
            a.ActiveWorkbook.ActiveSheet.Cells(i, 2).Value = nombre;
            a.ActiveWorkbook.ActiveSheet.Cells(i, 3).Value = precio;
            a.ActiveWorkbook.ActiveSheet.Cells(i, 4).Value = existencia;
            a.ActiveWorkbook.ActiveSheet.Cells(i, 5).Value = medida;
            a.ActiveWorkbook.ActiveSheet.Cells(i, 6).Value = fecha;
            a.ActiveWorkbook.ActiveSheet.Cells(i, 7).Value = proveedor;
            i++;
            a.ActiveWorkbook.Save();
            MessageBox.Show("Se agregaron los datos al excel", "Lectura y Escritura", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            lvProductos.Items.Clear();
            int x = 5;
            string p = cbPorProveedor.Text;
            cbPorProveedor.ResetText();
            while (a.ActiveWorkbook.ActiveSheet.Cells(x, 1).Value != null)
            {
                string id = a.ActiveWorkbook.ActiveSheet.Cells(x, 1).Value.ToString();
                string nombre = a.ActiveWorkbook.ActiveSheet.Cells(x, 2).Value.ToString();
                string precio = a.ActiveWorkbook.ActiveSheet.Cells(x, 3).Value.ToString();
                string existencia = a.ActiveWorkbook.ActiveSheet.Cells(x, 4).Value.ToString();
                string medida = a.ActiveWorkbook.ActiveSheet.Cells(x, 5).Value.ToString();
                string fecha = a.ActiveWorkbook.ActiveSheet.Cells(x, 6).Value.ToString();
                string proveedor = a.ActiveWorkbook.ActiveSheet.Cells(x, 7).Value.ToString();
                ListViewItem lista = new ListViewItem(id);
                if (proveedor == p)
                {
                    lista.SubItems.Add(nombre);
                    lista.SubItems.Add(precio);
                    lista.SubItems.Add(existencia);
                    lista.SubItems.Add(medida);
                    lista.SubItems.Add(fecha);
                    lista.SubItems.Add(proveedor);
                    lvProductos.Items.Add(lista);
                }
                x++;
            }         
        }

        private void btnFecha_Click(object sender, EventArgs e)
        {
            lvProductos.Items.Clear();
            int x = 5;
            string f = txtPorFecha.Text;
            txtPorFecha.Clear();
            while (a.ActiveWorkbook.ActiveSheet.Cells(x, 1).Value != null)
            {
                string id = a.ActiveWorkbook.ActiveSheet.Cells(x, 1).Value.ToString();
                string nombre = a.ActiveWorkbook.ActiveSheet.Cells(x, 2).Value.ToString();
                string precio = a.ActiveWorkbook.ActiveSheet.Cells(x, 3).Value.ToString();
                string existencia = a.ActiveWorkbook.ActiveSheet.Cells(x, 4).Value.ToString();
                string medida = a.ActiveWorkbook.ActiveSheet.Cells(x, 5).Value.ToString();
                string fecha = a.ActiveWorkbook.ActiveSheet.Cells(x, 6).Value.ToString();
                string proveedor = a.ActiveWorkbook.ActiveSheet.Cells(x, 7).Value.ToString();
                ListViewItem lista = new ListViewItem(id);
                if (fecha == f)
                {
                    lista.SubItems.Add(nombre);
                    lista.SubItems.Add(precio);
                    lista.SubItems.Add(existencia);
                    lista.SubItems.Add(medida);
                    lista.SubItems.Add(fecha);
                    lista.SubItems.Add(proveedor);
                    lvProductos.Items.Add(lista);
                }
                x++;
            }
        }

        private void btnPorcentaje_Click(object sender, EventArgs e)
        {
            int x = 5;
            int y = 5;
            int pan = 0;
            int carnes = 0;
            int jumex = 0;
            int kelloggs = 0;
            int coca = 0;
            int total = 0;
            while (a.ActiveWorkbook.ActiveSheet.Cells(y, 1).Value != null)
            {
                total++;
                y++;
            }
            while (a.ActiveWorkbook.ActiveSheet.Cells(x, 7).Value != null)
            {
                string i = a.ActiveWorkbook.ActiveSheet.Cells(x, 7).Value.ToString();

                switch (i)
                {
                    case "Panaderia Mayra":
                        pan++;
                        break;
                    case "Carnes Chuy":
                        carnes++;
                        break;
                    case "Jumex":
                        jumex++;
                        break;
                    case "Kellog's":
                        kelloggs++;
                        break;
                    case "CocaCola":
                        coca++;
                        break;
                }
                x++;
            }

            decimal tPan = (pan * 100) / total;
            decimal tCarnes = (carnes * 100) / total;
            decimal tJumex = (jumex * 100) / total;
            decimal tKellogs = (kelloggs * 100) / total;
            decimal tCoca = (coca * 100) / total;

            MessageBox.Show("Porcentaje por Proveedor: " +
                "Panaderia Mayra: " + tPan + "%   " +
                "Carnes Chuy: " + tCarnes + "%   " +
                "Jumex: " + tJumex + "%   " +
                "Kellog's: " + tKellogs + "%   " +
              "Coca Cola: " + tCoca + "%   ");
        }
    }
}

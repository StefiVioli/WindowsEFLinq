using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WindowsEFLinq.Data;//Agregar


namespace WindowsEFLinq
{
    public partial class Form1 : Form
    {
        //crear una instancia del dbcontext

        NorthwindContext context = new NorthwindContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTraerTodos_Click(object sender, EventArgs e)
        {
            //traer todos
            var lista = (from p in context.Products
                         select p).ToList();

            gridProductos.DataSource = lista;

        }

        private void btnTraerPorCategoria_Click(object sender, EventArgs e)
        {
            int categoriaId = 2;

            var lista = (from p in context.Products
                         where p.CategoryID == categoriaId
                         select p).ToList();
            gridProductos.DataSource = lista;

        }

        private void btnTraerPorNombre_Click(object sender, EventArgs e)
        {
            string nombreproducto = "Konbu";

            var producto = (from p in context.Products
                            where p.ProductName == nombreproducto
                            select p).SingleOrDefault();
            MessageBox.Show(producto.ProductName + " " + producto.UnitPrice.ToString());

        }

        private void btnTraerId_Click(object sender, EventArgs e)
        {
            int id = 2;
            var producto = (from p in context.Products
                            where p.ProductID == id
                            select p).SingleOrDefault();
            MessageBox.Show(producto.ProductName + " " + producto.UnitPrice.ToString());

        }

        private void btnTraerProductoCategoria_Click(object sender, EventArgs e)
        {
            var lista = (
                       from
                       c in context.Categories
                       join
                       p in context.Products
                       on c.CategoryID equals p.CategoryID
                       select new
                       {
                           c.CategoryID,
                           Category = c.CategoryName,
                           Product = p.ProductName,
                           p.UnitPrice
                       }
               ).ToList();

            gridProductos.DataSource = lista;

        }
    }
}

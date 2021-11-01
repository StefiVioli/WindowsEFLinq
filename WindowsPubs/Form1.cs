using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsPubs.Data;

namespace WindowsPubs
{
    public partial class Form1 : Form
    {
        //crear una instancia del dbcontext

        PubsContext context = new PubsContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTraerTodosAutores_Click(object sender, EventArgs e)
        {
            //traer todos los autores
            var lista = (from a in context.authors
                         select a).ToList();

            gridPublicaciones.DataSource = lista;
        }

        private void btnTraerTodosPublicadores_Click(object sender, EventArgs e)
        {
            //traer todos los publicadores
            var lista = (from p in context.publishers
                         select p).ToList();

            gridPublicaciones.DataSource = lista;
        }

        private void btnTraerTodosAutoresPorCiudad_Click(object sender, EventArgs e)
        {
            string city = "Oakland";

            var lista = (from a in context.authors
                         where a.city == city
                         select a).ToList();
            gridPublicaciones.DataSource = lista;

        }

        private void btnTraerAutorPorId_Click(object sender, EventArgs e)
        {
            string id = "893-72-1158";
            var autor = (from a in context.authors
                            where a.au_id == id
                            select a).SingleOrDefault();
            MessageBox.Show(autor.au_fname + " " + autor.au_lname);

        }

        private void btnTraerPublicadorPorNombre_Click(object sender, EventArgs e)
        {

            string nombre = "New Moon Books";
            var pub = (from p in context.publishers
                         where p.pub_name == nombre
                         select p).SingleOrDefault();
            MessageBox.Show(pub.pub_name + " " + pub.pub_id);

        }

        private void btnSalesStores_Click(object sender, EventArgs e)
        {
            var lista = (
                       from
                       sa in context.sales
                       join
                       st in context.stores
                       on sa.stor_id equals st.stor_id
                       select new
                       {
                           st.stor_id,
                           st.stor_name,
                           st.city,
                           sa.ord_num,
                           sa.ord_date,
                           sa.qty,
                           sa.title_id
                          
                       }
               ).ToList();

            gridPublicaciones.DataSource = lista;

        }

        private void btnEmployeePublisher_Click(object sender, EventArgs e)
        {
            var lista = (
                       from
                       em in context.employees
                       join
                       p in context.publishers
                       on em.pub_id equals p.pub_id
                       select new
                       {
                          em.fname,
                          em.lname,
                          p.pub_name

                       }
               ).ToList();

            gridPublicaciones.DataSource = lista;
        }

        private void btnFiltrarPorPais_Click(object sender, EventArgs e)
        {
            string country = "USA";
            var lista = (
                       from
                       em in context.employees
                       join
                       p in context.publishers
                       on em.pub_id equals p.pub_id
                       where p.country==country
                       select new
                       {
                           em.fname,
                           em.lname,
                           p.pub_name

                       }
               ).ToList();

            gridPublicaciones.DataSource = lista;
        }
    }
}

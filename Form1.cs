using System.Diagnostics.Eventing.Reader;

namespace Control_Registro_de_ventas
{
    public partial class Form1 : Form
    {
        double precio = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblFeha.Text = DateTime.Today.Date.ToString("d");
            lblPrecio.Text = (0).ToString("c");
        }

        private void cboProductos_selectedIndexchanged(object sender, EventArgs e)
        {
            string producto = cboProductos.Text;
            if (producto.Equals("Coleccion Escolar")) precio = 250;
            if (producto.Equals("Coleccion PreUniversitaria")) precio = 150;
            if (producto.Equals("Coleccion Profesional")) precio = 350;

            lblPrecio.Text = precio.ToString("C");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //validando
            if (cboProductos.SelectedIndex == -1) { }
            MessageBox.Show("Debe seleccionar un producto...!!!");
            if (txtCantidad.Text == "")
                MessageBox.Show("Debe ingresar una cantidad...!!!");
            if (cboTipo.SelectedIndex == -1) { }
            MessageBox.Show("Debe seleccionar un tipo...!!!");
            if (cboTipo.SelectedIndex == -1) ;
            MessageBox.Show("Debe seleccionar un tipo...!!!");

            //cacturando datos
            string producto = cboProductos.Text;
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            string tipo = cboTipo.Text;

            // procesar calculos
            double subtotal = cantidad * precio;

            double descuento = 0, recargo = 0;
            if (tipo.Equals("contado")) ;
            descuento = 0.05 * subtotal;

            recargo = 0.1 * subtotal;
            double preciofinal = subtotal - descuento + recargo;


            //impresion de resultados
            ListViewItem fila = new ListViewItem(producto);
            fila.SubItems.Add(cantidad.ToString());
            fila.SubItems.Add(precio.ToString());
            fila.SubItems.Add(tipo);
            fila.SubItems.Add(descuento.ToString());
            fila.SubItems.Add(recargo.ToString());
            fila.SubItems.Add(cantidad.ToString());

            lvVenta.Items.Add(fila);
            btnCancelar.Click(object sender, (e;

        }

    }
    private void btncancelar_click(object sender, EventArgs e)
    {
        
    }
}








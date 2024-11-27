using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caso_3Modelado.Players;
using Caso_3Modelado.StrategyPattern;

namespace Caso_3Modelado
{
    public partial class GameForm : Form
    {
        public List<Player> Players = new List<Player>();
        public Player1 Player1 = new Player1();
        public Player2 Player2 = new Player2();
        private System.Windows.Forms.Timer GameTimer;
        private int turno = 1;

        public GameForm()
        {
            InitializeComponent();

            Players.Add(Player1);
            Players.Add(Player2);
            inicializarJuego();

        }
        public void setArtesPlayers()
        {
            foreach (var player in Players)
            {
                player.setArtesMarciales();
            }


            lblVidaP1.Text = $"Vida: {Players[0].getVida().ToString()} / 200";
            comboBoxOpciones(ComboBoxArtesMarcialP1, Players[0].artesMarciales);

            P1_ArteMarcial_1.Text = Players[0].artesMarciales[0].Nombre;
            ActualizarTecnicasTXTBox(Players[0].artesMarciales[0], Tecnicas1P1);

            P1_ArteMarcial_2.Text = Players[0].artesMarciales[1].Nombre;
            ActualizarTecnicasTXTBox(Players[0].artesMarciales[1], Tecnicas2P1);

            P1_ArteMarcial_3.Text = Players[0].artesMarciales[2].Nombre;
            ActualizarTecnicasTXTBox(Players[0].artesMarciales[2], Tecnicas3P1);


            lblVidaP2.Text = $"Vida: {Players[0].getVida().ToString()} / 200";

            P2_ArteMarcial_1.Text = Players[1].artesMarciales[0].Nombre;
            ActualizarTecnicasTXTBox(Players[1].artesMarciales[0], Tecnicas1P2);

            P2_ArteMarcial_2.Text = Players[1].artesMarciales[1].Nombre;
            ActualizarTecnicasTXTBox(Players[1].artesMarciales[1], Tecnicas2P2);

            P2_ArteMarcial_3.Text = Players[1].artesMarciales[2].Nombre;
            ActualizarTecnicasTXTBox(Players[1].artesMarciales[2], Tecnicas3P2);

        }

        private void inicializarJuego()
        {
            Player1.setVida(200);
            Player2.setVida(200);

            // Restablece las artes marciales
            Player1.setArtesMarciales();
            Player2.setArtesMarciales();

            // Actualiza el ComboBox y las listas de técnicas
            comboBoxOpciones(ComboBoxArtesMarcialP1, Player1.artesMarciales);
            ActualizarTecnicasTXTBox(Player1.artesMarciales[0], Tecnicas1P1);
            ActualizarTecnicasTXTBox(Player1.artesMarciales[1], Tecnicas2P1);
            ActualizarTecnicasTXTBox(Player1.artesMarciales[2], Tecnicas3P1);

            ActualizarTecnicasTXTBox(Player2.artesMarciales[0], Tecnicas1P2);
            ActualizarTecnicasTXTBox(Player2.artesMarciales[1], Tecnicas2P2);
            ActualizarTecnicasTXTBox(Player2.artesMarciales[2], Tecnicas3P2);

            // Limpiar las bitácoras de ambos jugadores
            Player1.BitacoraAtaques.Clear();
            Player2.BitacoraAtaques.Clear();
            BitacoraP1.Items.Clear();
            BitacoraP2.Items.Clear();

            // Restablece las etiquetas de vida
            ActualizarVidas();

            // Reinicia el turno
            turno = 1;
        }

        public void ActualizarTecnicasTXTBox(IArteMarcial arteMarcial, ListBox tecnicasListBox)
        {
            tecnicasListBox.Items.Clear();
            foreach (var tecnica in arteMarcial.DescripcionesGolpes)
            {
                tecnicasListBox.Items.Add($"{tecnica.Value.descripcion} - {tecnica.Value.poder}");
            }
        }

        private void comboBoxOpciones(ComboBox comboBox, List<IArteMarcial> artesMarciales)
        {
            comboBox.SelectedItem = -1;
            comboBox.Text = String.Empty;
            comboBox.Items.Clear();



            foreach (var arteMarcial in artesMarciales)
            {
                comboBox.Items.Add(arteMarcial.Nombre);
            }
        }

        private void ActualizarVidas()
        {
            lblVidaP1.Text = $"Vida: {Players[0].getVida().ToString()} / 200";
            lblVidaP2.Text = $"Vida: {Players[1].getVida().ToString()} / 200";
        }

        private void ActualizarBitacoras()
        {

            foreach (var ataque in Player1.BitacoraAtaques)
            {
                BitacoraP1.Items.Add($"{turno}: {ataque}");
            }
            Player1.BitacoraAtaques.Clear();

            foreach (var ataque in Player2.BitacoraAtaques)
            {
                BitacoraP2.Items.Add($"{turno}: {ataque}");
            }
            Player2.BitacoraAtaques.Clear();
        }

        private void MostrarMensajeFinal(string ganador)
        {
            DialogResult result = MessageBox.Show($"{ganador} ha ganado el juego. ¿Quieres reiniciar?", "Fin del juego", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                inicializarJuego();
            }
            else
            {
                Close(); // Cierra el formulario si elige no reiniciar
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void P2_ArteMarcial_2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void P1_ArteMarcial_2_Click(object sender, EventArgs e)
        {

        }

        private void P2_ArteMarcial_3_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



        private void button6_Click(object sender, EventArgs e)
        {

            Players[0].setArtesMarciales();
            comboBoxOpciones(ComboBoxArtesMarcialP1, Players[0].artesMarciales);

            P1_ArteMarcial_1.Text = Players[0].artesMarciales[0].Nombre;
            ActualizarTecnicasTXTBox(Players[0].artesMarciales[0], Tecnicas1P1);

            P1_ArteMarcial_2.Text = Players[0].artesMarciales[1].Nombre;
            ActualizarTecnicasTXTBox(Players[0].artesMarciales[1], Tecnicas2P1);

            P1_ArteMarcial_3.Text = Players[0].artesMarciales[2].Nombre;
            ActualizarTecnicasTXTBox(Players[0].artesMarciales[2], Tecnicas3P1);
        }


        private void button7_Click(object sender, EventArgs e)
        {
            Players[1].setArtesMarciales();

            P2_ArteMarcial_1.Text = Players[1].artesMarciales[0].Nombre;
            ActualizarTecnicasTXTBox(Players[1].artesMarciales[0], Tecnicas1P2);

            P2_ArteMarcial_2.Text = Players[1].artesMarciales[1].Nombre;
            ActualizarTecnicasTXTBox(Players[1].artesMarciales[1], Tecnicas2P2);

            P2_ArteMarcial_3.Text = Players[1].artesMarciales[2].Nombre;
            ActualizarTecnicasTXTBox(Players[1].artesMarciales[2], Tecnicas3P2);
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (ComboBoxArtesMarcialP1.SelectedIndex != -1)
            {
                Player1.Atacar(Player1, Player2);
                Player2.Atacar(Player2, Player1);

                ActualizarVidas();
                ActualizarBitacoras();
                turno++;

                if (Player1.getVida() <= 0 || Player2.getVida() <= 0)
                {
                    string ganador = Player1.getVida() <= Player2.getVida() ? "Jugador 2" : "Jugador 1";
                    MostrarMensajeFinal(ganador);
                }
            }
            else
            {
                MessageBox.Show("Selecciona un arte marcial");
            }
        }

        private void TecnicasP1AM1_TextChanged(object sender, EventArgs e)
        {

        }

        private void VidaP1_Click(object sender, EventArgs e)
        {

        }

        private void ComboBoxArtesMarcialP1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string arteMarcialSeleccionada = ComboBoxArtesMarcialP1.SelectedItem.ToString();

            IArteMarcial arteMarcial = Player1.artesMarciales.FirstOrDefault(a => a.Nombre == arteMarcialSeleccionada);
            Player1.SeleccionarArteMarcial(arteMarcial);
        }

        private void BitacoraP1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

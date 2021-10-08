using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogo_labirinto
{
    public partial class d : Form
    {
        public d()
        {
            InitializeComponent();
        }


        public int moviment;
        
        int passagem = 1;
        int contadorv = 10;
        int contadorr = 8;
        int velocidade = 2;
        int pontos = 0;
        int criptografia = 1;
        string user = System.Windows.Forms.SystemInformation.UserName;

        public void limite(int altura, int lateral, int comparar)
        {
            if (comparar == 1)
            {
                if (car.Top < altura && car.Left < lateral) { car.Top = 308; car.Left = 160; velocidade = 0; MessageBox.Show("Você saiu do limite da pista"); pontos = 0; }
            }

            else if (comparar == 2)
            {
                if (car.Top < altura && car.Left > lateral) { car.Top = 308; car.Left = 160; velocidade = 0; MessageBox.Show("Você saiu do limite da pista"); pontos = 0; }
            }

            else if (comparar == 3)
            {
                if (car.Top > altura && car.Left > lateral) { car.Top = 308; car.Left = 160; velocidade = 0; MessageBox.Show("Você saiu do limite da pista"); pontos = 0; }
            }

            else if (comparar == 4)
            {
                if (car.Top > altura && car.Left < lateral) { car.Top = 308; car.Left = 160; velocidade = 0; MessageBox.Show("Você saiu do limite da pista"); pontos = 0; }
            }
        }
        public void limite2(int cima, int baixo, int esquerda, int direita)
        {
            if (car.Top < baixo && car.Top > cima && car.Left > esquerda && car.Left < direita)
            {
                car.Top = 308; car.Left = 160; velocidade = 0; MessageBox.Show("Você saiu do limite da pista") ; pontos = 0;
            }


        }
        public void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            label1.Text = Convert.ToString(e.KeyValue);
            if (e.KeyValue == 87) { moviment = 1; }//subir
            else if (e.KeyValue == 83) { moviment = 2; }//descer
            else if (e.KeyValue == 68) { moviment = 3; }//direita
            else if (e.KeyValue == 65) { moviment = 4; }//esquerda
            else if (e.KeyValue == 32) { moviment = 5; }//parar
            else if (e.KeyValue == 74) { velocidade = velocidade + 1; }//aumenta velocidade
            else if (e.KeyValue == 72) { velocidade = velocidade - 1; }//diminui velocidadee
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (moviment == 1) { car.Top = car.Top - velocidade; car.Image = Image.FromFile(@"C:/Users/" + user + @"/Desktop/jogo-labirinto/Resources/carro projetobaixo.png"); car.Size = new Size(35, 53); }
            if (moviment == 2) { car.Top = car.Top + velocidade; car.Image = Image.FromFile(@"C:/Users/" + user + @"/Desktop/jogo-labirinto/Resources/carro projetocima.png"); car.Size = new Size(35, 53); }
            if (moviment == 3) { car.Left = car.Left + velocidade; car.Image = Image.FromFile(@"C:/Users/" + user + @"/Desktop/jogo-labirinto/Resources/carro projetoesqueda.png"); car.Size = new Size(53, 35); }
            if (moviment == 4) { car.Left = car.Left - velocidade; car.Image = Image.FromFile(@"C:/Users/" + user + @"/Desktop/jogo-labirinto/Resources/carro projetodireita.png"); car.Size = new Size(53, 35); }
            if (moviment == 5) { car.Left = car.Left + 0; car.Top = car.Top + 0; velocidade = 2; }

            if (passagem == 2)
            {
              if (car.Top < 104 && car.Top > -7 && car.Left > 413 && car.Left < 500) { car.Top = 308; car.Left = 160; velocidade = 0; MessageBox.Show("               VOCÊ PERDEU!!\nVocê passou no sinal vermelho!\n\nSempre espere o sinal verde para poder avançar"); pontos = 0; }
              if (car.Top < 393 && car.Top > 289 && car.Left > 460 && car.Left < 561) { car.Top = 308; car.Left = 160; velocidade = 0; MessageBox.Show("               VOCÊ PERDEU!!\nVocê passou no sinal vermelho!\n\nSempre espere o sinal verde para poder avançar"); pontos = 0; }
              if(car.Top < 446 && car.Top > 340 && car.Left > 126 && car.Left < 234) { car.Top = 308; car.Left = 160; velocidade = 0; MessageBox.Show("               VOCÊ PERDEU!!\nVocê passou no sinal vermelho!\n\nSempre espere o sinal verde para poder avançar"); pontos = 0; }
            }

            if (passagem == 1)
            {
                if (car.Top < 104 && car.Top > -7 && car.Left > 413 && car.Left < 500) { criptografia = 2; }
                if (car.Top < 393 && car.Top > 289 && car.Left > 460 && car.Left < 561) { criptografia = 2; }
                if (car.Top < 446 && car.Top > 340 && car.Left > 126 && car.Left < 234) { criptografia = 2; }
                

            }


            limite(202, 210, 1);
            limite(-18, 690, 1);
            limite(680, 690, 2);
            limite(335, 570, 3);
            limite(680, -8, 3);
            limite(445, 346, 4);
            limite(680, -4, 1);
            limite2(104, 347, 336, 460 );
            limite2(104, 225, 336, 574);
            limite2(308, 584, 444, 460);
            limite2(329, 347, 105, 460);
            label7.Text = "Pontos: " + Convert.ToString(pontos);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rectangleShape7_Click(object sender, EventArgs e)
        {

        }

        private void ball_Click(object sender, EventArgs e)
        {

        }

        private void car_Click(object sender, EventArgs e)
        {

        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }

        public void timer2_Tick(object sender, EventArgs e)
        {
            contadorv--;
            label2.Text = Convert.ToString("Semáforo verde: " + contadorv);
            label3.Text = Convert.ToString("Semáforo vermelho: " + contadorr);
            //label4.Text = Convert.ToString("status" + passagem);
            //label5.Text = Convert.ToString("altura" + car.Top);
            //label6.Text = Convert.ToString("lateral" + car.Left);
            ovalShape1.BackColor = Color.Green;
            ovalShape3.BackColor = Color.Green;
            ovalShape6.BackColor = Color.Green;
            if (contadorv <= 0)
            {
                ovalShape2.BackColor = Color.Red;//primeiro semaforo
                ovalShape1.BackColor = Color.Gray;
                ovalShape4.BackColor = Color.Red;
                ovalShape3.BackColor = Color.Gray;//segundo semaforo
                ovalShape5.BackColor = Color.Red;
                ovalShape6.BackColor = Color.Gray;
                contadorr--;
                passagem = 2;
                
                
               
                
                if (contadorr == 0)
                {
                    contadorv = 10;
                    ovalShape1.BackColor = Color.Green;
                    ovalShape3.BackColor = Color.Green;
                    ovalShape6.BackColor = Color.Green;
                    contadorr = 8;
                    ovalShape2.BackColor = Color.Gray;
                    ovalShape4.BackColor = Color.Gray;
                    ovalShape5.BackColor = Color.Gray;
                    passagem = 1;
                }              
            }

            if (criptografia == 2) { pontos++; }
            criptografia = 1;

        }

        private void ovalShape1_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
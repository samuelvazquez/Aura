using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using inventory.modelos;

namespace inventory.Vistas
{
    class Login : Panel
    {

        public String User, Password;

        private ModelUsuarios usuarios;

        private Main Main;
        private Label lb_contrasena;
        private TextBox txt_usuario;
        private TextBox txt_contrasena;
        private Button btn_entrar;
        private Label lb_error;
        private Panel pnl_imagen_login;
        private Label lb_usuario;

        public Panel PanelLogin(Main Main)
        {
            
            this.Main = Main;
            usuarios = new ModelUsuarios();

            this.InitializeComponent();

            //Main.Location = Screen.PrimaryScreen.WorkingArea.Location;
            //Main.Size = Screen.PrimaryScreen.WorkingArea.Size;

            int Width = Main.Size.Width;
            int Height = Main.Size.Height;

            // Initialize the Panel control.
            this.Location = new Point(Width / 2, Height / 2);
            this.Size = new Size(Width / 2, Height / 3);

            Main.Top = (Screen.PrimaryScreen.WorkingArea.Height) / 4;
            Main.Left = (Screen.PrimaryScreen.WorkingArea.Width) / 3;
            Main.Size = new Size(Width / 2, Height / 3);

            Main.ControlBox = false;
            Main.FormBorderStyle = FormBorderStyle.FixedSingle;


            this.Left = (Main.Width - this.Width) / 2;
            this.Top = 0;

            

            //this.BackColor = Color.CornflowerBlue;

            this.lb_usuario.Location = new System.Drawing.Point(this.Width / 2 + 20, 5);
            this.Controls.Add(this.lb_usuario);

            this.lb_contrasena.Location = new System.Drawing.Point(this.Width / 2 + 20, 50);
            this.Controls.Add(this.lb_contrasena);

            this.txt_usuario.Location = new System.Drawing.Point(this.Width / 2 + 20, 25);
            this.Controls.Add(this.txt_usuario);

            this.txt_contrasena.Location = new System.Drawing.Point(this.Width / 2 + 20, 70);
            this.Controls.Add(this.txt_contrasena);

            this.btn_entrar.Location = new System.Drawing.Point(this.Width / 2 + 20, 100);
            this.Controls.Add(this.btn_entrar);

            this.lb_error.Location = new System.Drawing.Point(10, 125);
            this.Controls.Add(this.lb_error);

            this.pnl_imagen_login.Size = new System.Drawing.Size(195, 125);
            this.Controls.Add(this.pnl_imagen_login);


            this.Dock = DockStyle.Fill;

            return this;
        }

        private void InitializeComponent()
        {
            this.lb_usuario = new System.Windows.Forms.Label();
            this.lb_contrasena = new System.Windows.Forms.Label();
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.txt_contrasena = new System.Windows.Forms.TextBox();
            this.btn_entrar = new System.Windows.Forms.Button();
            this.lb_error = new System.Windows.Forms.Label();
            this.pnl_imagen_login = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lb_usuario
            // 
            this.lb_usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_usuario.AutoSize = true;
            this.lb_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_usuario.Location = new System.Drawing.Point(0, 0);
            this.lb_usuario.Name = "lb_usuario";
            this.lb_usuario.Size = new System.Drawing.Size(100, 23);
            this.lb_usuario.TabIndex = 0;
            this.lb_usuario.Text = "Usuario";
            // 
            // lb_contrasena
            // 
            this.lb_contrasena.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_contrasena.AutoSize = true;
            this.lb_contrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_contrasena.Location = new System.Drawing.Point(0, 60);
            this.lb_contrasena.Name = "lb_contrasena";
            this.lb_contrasena.Size = new System.Drawing.Size(100, 23);
            this.lb_contrasena.TabIndex = 0;
            this.lb_contrasena.Text = "Contraseña";
            // 
            // txt_usuario
            // 
            this.txt_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.Location = new System.Drawing.Point(0, 30);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(150, 22);
            this.txt_usuario.TabIndex = 0;
            // 
            // txt_contrasena
            // 
            this.txt_contrasena.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_contrasena.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_contrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contrasena.Location = new System.Drawing.Point(0, 90);
            this.txt_contrasena.MaxLength = 15;
            this.txt_contrasena.Name = "txt_contrasena";
            this.txt_contrasena.PasswordChar = '*';
            this.txt_contrasena.Size = new System.Drawing.Size(150, 22);
            this.txt_contrasena.TabIndex = 0;
            // 
            // btn_entrar
            // 
            this.btn_entrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entrar.Location = new System.Drawing.Point(0, 120);
            this.btn_entrar.Name = "btn_entrar";
            this.btn_entrar.Size = new System.Drawing.Size(135, 23);
            this.btn_entrar.TabIndex = 0;
            this.btn_entrar.Text = "Entrar";
            this.btn_entrar.UseVisualStyleBackColor = true;
            this.btn_entrar.Click += new System.EventHandler(this.btn_entrar_Click);
            // 
            // lb_error
            // 
            this.lb_error.AutoSize = true;
            this.lb_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_error.ForeColor = System.Drawing.Color.Red;
            this.lb_error.Location = new System.Drawing.Point(0, 150);
            this.lb_error.Name = "lb_error";
            this.lb_error.Size = new System.Drawing.Size(100, 23);
            this.lb_error.TabIndex = 0;
            // 
            // pnl_imagen_login
            // 
            this.pnl_imagen_login.BackColor = System.Drawing.Color.Transparent;
            this.pnl_imagen_login.BackgroundImage = global::inventory.Properties.Resources.login;
            this.pnl_imagen_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pnl_imagen_login.Location = new System.Drawing.Point(0, 0);
            this.pnl_imagen_login.Name = "pnl_imagen_login";
            this.pnl_imagen_login.Size = new System.Drawing.Size(200, 100);
            this.pnl_imagen_login.TabIndex = 0;
            // 
            // Login
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ForeColor = System.Drawing.Color.Black;
            this.ResumeLayout(false);

        }

        private void btn_entrar_Click(object sender, EventArgs e)
        { 
            this.User = txt_usuario.Text;
            this.Password = txt_contrasena.Text; 

            if (this.User.Equals("") || this.Password.Equals(""))
            {
                lb_error.Text = "Por Favor escriba su Usuario y Contraseña";
            }
            else
            { 
                usuarios.conection = Main.conection;
                if (usuarios.getLogin(User, Password))
                {
                    Main.Contenedor.Controls.Clear();
                    Main.menuStrip1.Visible = true;

                    Main.Location = Screen.PrimaryScreen.WorkingArea.Location;
                    Main.Size = Screen.PrimaryScreen.WorkingArea.Size;

                    Main.ControlBox = true;
                    Main.MaximizeBox = false;

                    Intro intro = new Intro();

                    Main.Contenedor.Controls.Add(intro);

                }
                else
                {
                    this.lb_error.Text = usuarios.getError();
                    //MessageBox.Show(usuarios.getError());
                }
            }
        }

        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {

        }

    }
}

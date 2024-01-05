namespace Empresa
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Elipse_form = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaColorTransition1 = new Guna.UI.WinForms.GunaColorTransition(this.components);
            this.txtRutaCarpeta = new Guna.UI.WinForms.GunaLineTextBox();
            this.lblPorcentaje = new Guna.UI.WinForms.GunaLabel();
            this.btnOrdenar = new Guna.UI.WinForms.GunaGradientButton();
            this.btnSeleccionarCarpeta_1 = new Guna.UI.WinForms.GunaGradientButton();
            this.Elipse_Carpeta = new Guna.UI.WinForms.GunaElipse(this.components);
            this.Elipse_ordenar = new Guna.UI.WinForms.GunaElipse(this.components);
            this.porcentaje_Graphic = new Bunifu.UI.WinForms.BunifuRadialGauge();
            this.bunifuFormCaptionButton1 = new Bunifu.UI.WinForms.BunifuFormCaptionButton();
            this.bunifuFormCaptionButton2 = new Bunifu.UI.WinForms.BunifuFormCaptionButton();
            this.gunaContextMenuStrip1 = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gunaGradient2Panel1 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.gunaGradient2Panel2 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaGradientButton6 = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaGradientButton5 = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaGradientButton4 = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaGradientButton3 = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaGradientButton2 = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaGradientButton1 = new Guna.UI.WinForms.GunaGradientButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gunaContextMenuStrip1.SuspendLayout();
            this.gunaGradient2Panel1.SuspendLayout();
            this.gunaGradient2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Elipse_form
            // 
            this.Elipse_form.TargetControl = this;
            // 
            // gunaColorTransition1
            // 
            this.gunaColorTransition1.ColorArray = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.Orange};
            this.gunaColorTransition1.EndColor = System.Drawing.Color.Blue;
            this.gunaColorTransition1.StartColor = System.Drawing.Color.Red;
            // 
            // txtRutaCarpeta
            // 
            this.txtRutaCarpeta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(254)))));
            this.txtRutaCarpeta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRutaCarpeta.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(212)))));
            this.txtRutaCarpeta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRutaCarpeta.ForeColor = System.Drawing.Color.White;
            this.txtRutaCarpeta.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(212)))));
            this.txtRutaCarpeta.Location = new System.Drawing.Point(491, 281);
            this.txtRutaCarpeta.Name = "txtRutaCarpeta";
            this.txtRutaCarpeta.PasswordChar = '\0';
            this.txtRutaCarpeta.SelectedText = "";
            this.txtRutaCarpeta.Size = new System.Drawing.Size(340, 30);
            this.txtRutaCarpeta.TabIndex = 2;
            this.txtRutaCarpeta.Tag = "";
            this.txtRutaCarpeta.Text = "Aqui va la ruta de la carpeta...";
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentaje.ForeColor = System.Drawing.Color.White;
            this.lblPorcentaje.Location = new System.Drawing.Point(467, 50);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(417, 52);
            this.lblPorcentaje.TabIndex = 3;
            this.lblPorcentaje.Text = "Ordenamineto de Carpetas";
            this.lblPorcentaje.UseCompatibleTextRendering = true;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.AnimationHoverSpeed = 0.07F;
            this.btnOrdenar.AnimationSpeed = 0.03F;
            this.btnOrdenar.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(254)))));
            this.btnOrdenar.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(212)))));
            this.btnOrdenar.BorderColor = System.Drawing.Color.Black;
            this.btnOrdenar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOrdenar.FocusedColor = System.Drawing.Color.Empty;
            this.btnOrdenar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOrdenar.ForeColor = System.Drawing.Color.White;
            this.btnOrdenar.Image = null;
            this.btnOrdenar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnOrdenar.Location = new System.Drawing.Point(724, 368);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.btnOrdenar.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.btnOrdenar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnOrdenar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnOrdenar.OnHoverImage = null;
            this.btnOrdenar.OnPressedColor = System.Drawing.Color.Black;
            this.btnOrdenar.Size = new System.Drawing.Size(160, 42);
            this.btnOrdenar.TabIndex = 1;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // btnSeleccionarCarpeta_1
            // 
            this.btnSeleccionarCarpeta_1.AnimationHoverSpeed = 0.07F;
            this.btnSeleccionarCarpeta_1.AnimationSpeed = 0.03F;
            this.btnSeleccionarCarpeta_1.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(254)))));
            this.btnSeleccionarCarpeta_1.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(212)))));
            this.btnSeleccionarCarpeta_1.BorderColor = System.Drawing.Color.Black;
            this.btnSeleccionarCarpeta_1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSeleccionarCarpeta_1.FocusedColor = System.Drawing.Color.Empty;
            this.btnSeleccionarCarpeta_1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSeleccionarCarpeta_1.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionarCarpeta_1.Image = null;
            this.btnSeleccionarCarpeta_1.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSeleccionarCarpeta_1.Location = new System.Drawing.Point(449, 368);
            this.btnSeleccionarCarpeta_1.Name = "btnSeleccionarCarpeta_1";
            this.btnSeleccionarCarpeta_1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(84)))));
            this.btnSeleccionarCarpeta_1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.btnSeleccionarCarpeta_1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSeleccionarCarpeta_1.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSeleccionarCarpeta_1.OnHoverImage = null;
            this.btnSeleccionarCarpeta_1.OnPressedColor = System.Drawing.Color.Black;
            this.btnSeleccionarCarpeta_1.Size = new System.Drawing.Size(160, 42);
            this.btnSeleccionarCarpeta_1.TabIndex = 0;
            this.btnSeleccionarCarpeta_1.Text = "Seleccionar Carpeta";
            this.btnSeleccionarCarpeta_1.Click += new System.EventHandler(this.btnSeleccionarCarpeta_Click_1);
            // 
            // Elipse_Carpeta
            // 
            this.Elipse_Carpeta.TargetControl = this.btnSeleccionarCarpeta_1;
            // 
            // Elipse_ordenar
            // 
            this.Elipse_ordenar.TargetControl = this.btnOrdenar;
            // 
            // porcentaje_Graphic
            // 
            this.porcentaje_Graphic.AutoGenerateProgressColorWhenHigh = true;
            this.porcentaje_Graphic.AutoGenerateProgressColorWhenLow = false;
            this.porcentaje_Graphic.BackColor = System.Drawing.Color.Transparent;
            this.porcentaje_Graphic.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.porcentaje_Graphic.ForeColor = System.Drawing.Color.White;
            this.porcentaje_Graphic.LighteningFactor = 70;
            this.porcentaje_Graphic.Location = new System.Drawing.Point(549, 128);
            this.porcentaje_Graphic.Margin = new System.Windows.Forms.Padding(7);
            this.porcentaje_Graphic.Maximum = 100;
            this.porcentaje_Graphic.Minimum = 0;
            this.porcentaje_Graphic.Name = "porcentaje_Graphic";
            this.porcentaje_Graphic.Prefix = "";
            this.porcentaje_Graphic.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(212)))));
            this.porcentaje_Graphic.ProgressBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(212)))));
            this.porcentaje_Graphic.ProgressCap = Bunifu.UI.WinForms.BunifuRadialGauge.CapStyles.Flat;
            this.porcentaje_Graphic.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(254)))));
            this.porcentaje_Graphic.ProgressColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(254)))));
            this.porcentaje_Graphic.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(254)))));
            this.porcentaje_Graphic.ProgressColorHigh = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(254)))));
            this.porcentaje_Graphic.ProgressColorLow = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(254)))));
            this.porcentaje_Graphic.ProgressHighValueMark = 100;
            this.porcentaje_Graphic.RangeEnd = 100;
            this.porcentaje_Graphic.RangeLabelsColor = System.Drawing.Color.White;
            this.porcentaje_Graphic.RangeLabelsFont = new System.Drawing.Font("Segoe UI", 8F);
            this.porcentaje_Graphic.RangeStart = 0;
            this.porcentaje_Graphic.ShowRangeLabels = true;
            this.porcentaje_Graphic.ShowValueLabel = true;
            this.porcentaje_Graphic.Size = new System.Drawing.Size(218, 127);
            this.porcentaje_Graphic.Suffix = "%";
            this.porcentaje_Graphic.TabIndex = 20;
            this.porcentaje_Graphic.Thickness = 30;
            this.porcentaje_Graphic.Value = 0;
            this.porcentaje_Graphic.ValueByTransition = 0;
            this.porcentaje_Graphic.ValueLabelColor = System.Drawing.Color.White;
            this.porcentaje_Graphic.WarningMark = 100;
            this.porcentaje_Graphic.ValueChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuRadialGauge.ValueChangedEventArgs>(this.bunifuRadialGauge1_ValueChanged);
            // 
            // bunifuFormCaptionButton1
            // 
            this.bunifuFormCaptionButton1.AllowAnimations = true;
            this.bunifuFormCaptionButton1.AllowBorderColorChanges = true;
            this.bunifuFormCaptionButton1.AllowDefaults = true;
            this.bunifuFormCaptionButton1.AllowMouseEffects = true;
            this.bunifuFormCaptionButton1.AnimationSpeed = 200;
            this.bunifuFormCaptionButton1.AutoSizeCaptions = true;
            this.bunifuFormCaptionButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFormCaptionButton1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuFormCaptionButton1.BackHoverColor = System.Drawing.Color.Transparent;
            this.bunifuFormCaptionButton1.BackPressedColor = System.Drawing.Color.Transparent;
            this.bunifuFormCaptionButton1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuFormCaptionButton1.BorderHoverColor = System.Drawing.Color.Transparent;
            this.bunifuFormCaptionButton1.BorderPressedColor = System.Drawing.Color.Transparent;
            this.bunifuFormCaptionButton1.BorderRadius = 1;
            this.bunifuFormCaptionButton1.BorderStyle = Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderStyles.Solid;
            this.bunifuFormCaptionButton1.BorderThickness = 1;
            this.bunifuFormCaptionButton1.CaptionType = Bunifu.UI.WinForms.BunifuFormCaptionButton.CaptionTypes.Minimize;
            this.bunifuFormCaptionButton1.ColorContrastOnClick = 30;
            this.bunifuFormCaptionButton1.ColorContrastOnHover = 30;
            this.bunifuFormCaptionButton1.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.bunifuFormCaptionButton1.CustomizableEdges = borderEdges4;
            this.bunifuFormCaptionButton1.DefaultBorderColor = System.Drawing.Color.Transparent;
            this.bunifuFormCaptionButton1.DefaultColor = System.Drawing.Color.Transparent;
            this.bunifuFormCaptionButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuFormCaptionButton1.IconColor = System.Drawing.Color.White;
            this.bunifuFormCaptionButton1.IconHoverColor = System.Drawing.Color.White;
            this.bunifuFormCaptionButton1.IconPressedColor = System.Drawing.Color.White;
            this.bunifuFormCaptionButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuFormCaptionButton1.Image")));
            this.bunifuFormCaptionButton1.ImageMargin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.bunifuFormCaptionButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.bunifuFormCaptionButton1.Location = new System.Drawing.Point(897, -1);
            this.bunifuFormCaptionButton1.Name = "bunifuFormCaptionButton1";
            this.bunifuFormCaptionButton1.ShowBorders = true;
            this.bunifuFormCaptionButton1.Size = new System.Drawing.Size(58, 48);
            this.bunifuFormCaptionButton1.TabIndex = 17;
            this.bunifuFormCaptionButton1.Click += new System.EventHandler(this.bunifuFormCaptionButton1_Click);
            // 
            // bunifuFormCaptionButton2
            // 
            this.bunifuFormCaptionButton2.AllowAnimations = true;
            this.bunifuFormCaptionButton2.AllowBorderColorChanges = true;
            this.bunifuFormCaptionButton2.AllowDefaults = true;
            this.bunifuFormCaptionButton2.AllowMouseEffects = true;
            this.bunifuFormCaptionButton2.AnimationSpeed = 200;
            this.bunifuFormCaptionButton2.AutoSizeCaptions = true;
            this.bunifuFormCaptionButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFormCaptionButton2.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuFormCaptionButton2.BackHoverColor = System.Drawing.Color.Transparent;
            this.bunifuFormCaptionButton2.BackPressedColor = System.Drawing.Color.Transparent;
            this.bunifuFormCaptionButton2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuFormCaptionButton2.BorderHoverColor = System.Drawing.Color.Transparent;
            this.bunifuFormCaptionButton2.BorderPressedColor = System.Drawing.Color.Transparent;
            this.bunifuFormCaptionButton2.BorderRadius = 1;
            this.bunifuFormCaptionButton2.BorderStyle = Bunifu.UI.WinForms.BunifuFormCaptionButton.BorderStyles.Solid;
            this.bunifuFormCaptionButton2.BorderThickness = 1;
            this.bunifuFormCaptionButton2.CaptionType = Bunifu.UI.WinForms.BunifuFormCaptionButton.CaptionTypes.Minimize;
            this.bunifuFormCaptionButton2.ColorContrastOnClick = 30;
            this.bunifuFormCaptionButton2.ColorContrastOnHover = 30;
            this.bunifuFormCaptionButton2.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.bunifuFormCaptionButton2.CustomizableEdges = borderEdges3;
            this.bunifuFormCaptionButton2.DefaultBorderColor = System.Drawing.Color.Transparent;
            this.bunifuFormCaptionButton2.DefaultColor = System.Drawing.Color.Transparent;
            this.bunifuFormCaptionButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuFormCaptionButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuFormCaptionButton2.IconColor = System.Drawing.Color.White;
            this.bunifuFormCaptionButton2.IconHoverColor = System.Drawing.Color.White;
            this.bunifuFormCaptionButton2.IconPressedColor = System.Drawing.Color.White;
            this.bunifuFormCaptionButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuFormCaptionButton2.Image")));
            this.bunifuFormCaptionButton2.ImageMargin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.bunifuFormCaptionButton2.ImageSize = new System.Drawing.Size(18, 18);
            this.bunifuFormCaptionButton2.Location = new System.Drawing.Point(835, -1);
            this.bunifuFormCaptionButton2.Name = "bunifuFormCaptionButton2";
            this.bunifuFormCaptionButton2.ShowBorders = true;
            this.bunifuFormCaptionButton2.Size = new System.Drawing.Size(58, 48);
            this.bunifuFormCaptionButton2.TabIndex = 18;
            this.bunifuFormCaptionButton2.Click += new System.EventHandler(this.bunifuFormCaptionButton2_Click);
            // 
            // gunaContextMenuStrip1
            // 
            this.gunaContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.gunaContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripMenuItem1});
            this.gunaContextMenuStrip1.Name = "gunaContextMenuStrip1";
            this.gunaContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaContextMenuStrip1.RenderStyle.ColorTable = null;
            this.gunaContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.gunaContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.gunaContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gunaContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.gunaContextMenuStrip1.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.gunaContextMenuStrip1.Size = new System.Drawing.Size(212, 95);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 28);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(208, 6);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 27);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(211, 24);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // gunaGradient2Panel1
            // 
            this.gunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel1.Controls.Add(this.gunaGradient2Panel2);
            this.gunaGradient2Panel1.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(254)))));
            this.gunaGradient2Panel1.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(212)))));
            this.gunaGradient2Panel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gunaGradient2Panel1.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.gunaGradient2Panel1.Location = new System.Drawing.Point(-3, -1);
            this.gunaGradient2Panel1.Name = "gunaGradient2Panel1";
            this.gunaGradient2Panel1.Size = new System.Drawing.Size(368, 465);
            this.gunaGradient2Panel1.TabIndex = 15;
            // 
            // gunaGradient2Panel2
            // 
            this.gunaGradient2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel2.Controls.Add(this.gunaLabel1);
            this.gunaGradient2Panel2.Controls.Add(this.gunaGradientButton5);
            this.gunaGradient2Panel2.Controls.Add(this.gunaGradientButton4);
            this.gunaGradient2Panel2.Controls.Add(this.gunaGradientButton3);
            this.gunaGradient2Panel2.Controls.Add(this.gunaGradientButton2);
            this.gunaGradient2Panel2.Controls.Add(this.gunaGradientButton1);
            this.gunaGradient2Panel2.Controls.Add(this.gunaGradientButton6);
            this.gunaGradient2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaGradient2Panel2.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(90)))), ((int)(((byte)(254)))));
            this.gunaGradient2Panel2.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(212)))));
            this.gunaGradient2Panel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gunaGradient2Panel2.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.gunaGradient2Panel2.Location = new System.Drawing.Point(0, 0);
            this.gunaGradient2Panel2.Name = "gunaGradient2Panel2";
            this.gunaGradient2Panel2.Size = new System.Drawing.Size(368, 465);
            this.gunaGradient2Panel2.TabIndex = 16;
            this.gunaGradient2Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaGradient2Panel2_Paint);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(122, 15);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(98, 52);
            this.gunaLabel1.TabIndex = 21;
            this.gunaLabel1.Text = "Menú";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.gunaLabel1.UseCompatibleTextRendering = true;
            // 
            // gunaGradientButton6
            // 
            this.gunaGradientButton6.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton6.AnimationSpeed = 0.03F;
            this.gunaGradientButton6.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.gunaGradientButton6.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.gunaGradientButton6.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton6.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton6.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaGradientButton6.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton6.Image = ((System.Drawing.Image)(resources.GetObject("gunaGradientButton6.Image")));
            this.gunaGradientButton6.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton6.Location = new System.Drawing.Point(1, 323);
            this.gunaGradientButton6.Name = "gunaGradientButton6";
            this.gunaGradientButton6.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.gunaGradientButton6.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaGradientButton6.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton6.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton6.OnHoverImage = null;
            this.gunaGradientButton6.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton6.Size = new System.Drawing.Size(364, 42);
            this.gunaGradientButton6.TabIndex = 5;
            this.gunaGradientButton6.Text = "gunaGradientButton6";
            // 
            // gunaGradientButton5
            // 
            this.gunaGradientButton5.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton5.AnimationSpeed = 0.03F;
            this.gunaGradientButton5.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.gunaGradientButton5.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.gunaGradientButton5.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton5.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton5.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaGradientButton5.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton5.Image = ((System.Drawing.Image)(resources.GetObject("gunaGradientButton5.Image")));
            this.gunaGradientButton5.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton5.Location = new System.Drawing.Point(1, 275);
            this.gunaGradientButton5.Name = "gunaGradientButton5";
            this.gunaGradientButton5.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.gunaGradientButton5.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaGradientButton5.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton5.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton5.OnHoverImage = null;
            this.gunaGradientButton5.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton5.Size = new System.Drawing.Size(364, 42);
            this.gunaGradientButton5.TabIndex = 4;
            this.gunaGradientButton5.Text = "gunaGradientButton5";
            // 
            // gunaGradientButton4
            // 
            this.gunaGradientButton4.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton4.AnimationSpeed = 0.03F;
            this.gunaGradientButton4.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.gunaGradientButton4.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.gunaGradientButton4.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton4.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaGradientButton4.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton4.Image = ((System.Drawing.Image)(resources.GetObject("gunaGradientButton4.Image")));
            this.gunaGradientButton4.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton4.Location = new System.Drawing.Point(1, 224);
            this.gunaGradientButton4.Name = "gunaGradientButton4";
            this.gunaGradientButton4.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.gunaGradientButton4.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaGradientButton4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton4.OnHoverImage = null;
            this.gunaGradientButton4.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton4.Size = new System.Drawing.Size(364, 42);
            this.gunaGradientButton4.TabIndex = 3;
            this.gunaGradientButton4.Text = "gunaGradientButton4";
            // 
            // gunaGradientButton3
            // 
            this.gunaGradientButton3.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton3.AnimationSpeed = 0.03F;
            this.gunaGradientButton3.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.gunaGradientButton3.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.gunaGradientButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaGradientButton3.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton3.Image = ((System.Drawing.Image)(resources.GetObject("gunaGradientButton3.Image")));
            this.gunaGradientButton3.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton3.Location = new System.Drawing.Point(1, 176);
            this.gunaGradientButton3.Name = "gunaGradientButton3";
            this.gunaGradientButton3.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.gunaGradientButton3.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaGradientButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton3.OnHoverImage = null;
            this.gunaGradientButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton3.Size = new System.Drawing.Size(364, 42);
            this.gunaGradientButton3.TabIndex = 2;
            this.gunaGradientButton3.Text = "Juegos gratis Epic";
            this.gunaGradientButton3.Click += new System.EventHandler(this.gunaGradientButton3_Click);
            // 
            // gunaGradientButton2
            // 
            this.gunaGradientButton2.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton2.AnimationSpeed = 0.03F;
            this.gunaGradientButton2.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.gunaGradientButton2.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.gunaGradientButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaGradientButton2.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaGradientButton2.Image")));
            this.gunaGradientButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton2.Location = new System.Drawing.Point(1, 128);
            this.gunaGradientButton2.Name = "gunaGradientButton2";
            this.gunaGradientButton2.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.gunaGradientButton2.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaGradientButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton2.OnHoverImage = null;
            this.gunaGradientButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton2.Size = new System.Drawing.Size(364, 42);
            this.gunaGradientButton2.TabIndex = 1;
            this.gunaGradientButton2.Text = "Ordenamiento de Carpetas";
            // 
            // gunaGradientButton1
            // 
            this.gunaGradientButton1.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton1.AnimationSpeed = 0.03F;
            this.gunaGradientButton1.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.gunaGradientButton1.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.gunaGradientButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaGradientButton1.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaGradientButton1.Image")));
            this.gunaGradientButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton1.Location = new System.Drawing.Point(1, 80);
            this.gunaGradientButton1.Name = "gunaGradientButton1";
            this.gunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.gunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.OnHoverImage = null;
            this.gunaGradientButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.Size = new System.Drawing.Size(364, 42);
            this.gunaGradientButton1.TabIndex = 0;
            this.gunaGradientButton1.Text = "Descargar Archivos";
            this.gunaGradientButton1.Click += new System.EventHandler(this.gunaGradientButton1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(953, 467);
            this.Controls.Add(this.bunifuFormCaptionButton2);
            this.Controls.Add(this.lblPorcentaje);
            this.Controls.Add(this.bunifuFormCaptionButton1);
            this.Controls.Add(this.porcentaje_Graphic);
            this.Controls.Add(this.btnSeleccionarCarpeta_1);
            this.Controls.Add(this.txtRutaCarpeta);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.gunaGradient2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gunaContextMenuStrip1.ResumeLayout(false);
            this.gunaContextMenuStrip1.PerformLayout();
            this.gunaGradient2Panel1.ResumeLayout(false);
            this.gunaGradient2Panel2.ResumeLayout(false);
            this.gunaGradient2Panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaElipse Elipse_form;
        private Guna.UI.WinForms.GunaColorTransition gunaColorTransition1;
        private Guna.UI.WinForms.GunaLabel lblPorcentaje;
        private Guna.UI.WinForms.GunaLineTextBox txtRutaCarpeta;
        private Guna.UI.WinForms.GunaGradientButton btnOrdenar;
        private Guna.UI.WinForms.GunaGradientButton btnSeleccionarCarpeta_1;
        private Guna.UI.WinForms.GunaElipse Elipse_Carpeta;
        private Guna.UI.WinForms.GunaElipse Elipse_ordenar;
        private Bunifu.UI.WinForms.BunifuRadialGauge porcentaje_Graphic;
        private Bunifu.UI.WinForms.BunifuFormCaptionButton bunifuFormCaptionButton1;
        private Bunifu.UI.WinForms.BunifuFormCaptionButton bunifuFormCaptionButton2;
        private Guna.UI.WinForms.GunaContextMenuStrip gunaContextMenuStrip1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel1;
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel2;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton6;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton5;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton4;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton3;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton2;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.Timer timer1;
    }
}


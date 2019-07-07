namespace Principal
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cmdAbrir = new System.Windows.Forms.Button();
            this.cmdEqualizar = new System.Windows.Forms.Button();
            this.cmdSalvar = new System.Windows.Forms.Button();
            this.imagemOriginal = new System.Windows.Forms.PictureBox();
            this.imagemEqualizada = new System.Windows.Forms.PictureBox();
            this.cmdEqualizarCores = new System.Windows.Forms.Button();
            this.chart_R_Original = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_G_Original = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_B_Original = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_P_Original = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_P_Equalizado = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_B_Equalizado = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_G_Equalizado = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_R_Equalizado = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.imagemOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemEqualizada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_R_Original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_G_Original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_B_Original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_P_Original)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_P_Equalizado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_B_Equalizado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_G_Equalizado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_R_Equalizado)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdAbrir
            // 
            this.cmdAbrir.Location = new System.Drawing.Point(12, 12);
            this.cmdAbrir.Name = "cmdAbrir";
            this.cmdAbrir.Size = new System.Drawing.Size(75, 23);
            this.cmdAbrir.TabIndex = 0;
            this.cmdAbrir.Text = "Abrir ";
            this.cmdAbrir.UseVisualStyleBackColor = true;
            this.cmdAbrir.Click += new System.EventHandler(this.cmdAbrir_Click);
            // 
            // cmdEqualizar
            // 
            this.cmdEqualizar.Enabled = false;
            this.cmdEqualizar.Location = new System.Drawing.Point(93, 12);
            this.cmdEqualizar.Name = "cmdEqualizar";
            this.cmdEqualizar.Size = new System.Drawing.Size(143, 23);
            this.cmdEqualizar.TabIndex = 1;
            this.cmdEqualizar.Text = "Equalizar Preto e Branco";
            this.cmdEqualizar.UseVisualStyleBackColor = true;
            this.cmdEqualizar.Click += new System.EventHandler(this.cmdEqualizar_Click);
            // 
            // cmdSalvar
            // 
            this.cmdSalvar.Enabled = false;
            this.cmdSalvar.Location = new System.Drawing.Point(363, 12);
            this.cmdSalvar.Name = "cmdSalvar";
            this.cmdSalvar.Size = new System.Drawing.Size(86, 23);
            this.cmdSalvar.TabIndex = 2;
            this.cmdSalvar.Text = "Salvar";
            this.cmdSalvar.UseVisualStyleBackColor = true;
            this.cmdSalvar.Click += new System.EventHandler(this.cmdSalvar_Click);
            // 
            // imagemOriginal
            // 
            this.imagemOriginal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.imagemOriginal.Location = new System.Drawing.Point(12, 57);
            this.imagemOriginal.Name = "imagemOriginal";
            this.imagemOriginal.Size = new System.Drawing.Size(437, 307);
            this.imagemOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagemOriginal.TabIndex = 3;
            this.imagemOriginal.TabStop = false;
            // 
            // imagemEqualizada
            // 
            this.imagemEqualizada.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.imagemEqualizada.Location = new System.Drawing.Point(12, 382);
            this.imagemEqualizada.Name = "imagemEqualizada";
            this.imagemEqualizada.Size = new System.Drawing.Size(437, 308);
            this.imagemEqualizada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagemEqualizada.TabIndex = 4;
            this.imagemEqualizada.TabStop = false;
            // 
            // cmdEqualizarCores
            // 
            this.cmdEqualizarCores.Enabled = false;
            this.cmdEqualizarCores.Location = new System.Drawing.Point(242, 12);
            this.cmdEqualizarCores.Name = "cmdEqualizarCores";
            this.cmdEqualizarCores.Size = new System.Drawing.Size(115, 23);
            this.cmdEqualizarCores.TabIndex = 5;
            this.cmdEqualizarCores.Text = "Equalizar Cores";
            this.cmdEqualizarCores.UseVisualStyleBackColor = true;
            this.cmdEqualizarCores.Click += new System.EventHandler(this.cmdEqualizarCores_Click);
            // 
            // chart_R_Original
            // 
            this.chart_R_Original.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart_R_Original.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_R_Original.Legends.Add(legend1);
            this.chart_R_Original.Location = new System.Drawing.Point(492, 197);
            this.chart_R_Original.Name = "chart_R_Original";
            this.chart_R_Original.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart_R_Original.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red};
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "R";
            this.chart_R_Original.Series.Add(series1);
            this.chart_R_Original.Size = new System.Drawing.Size(353, 154);
            this.chart_R_Original.TabIndex = 6;
            this.chart_R_Original.Text = "R";
            // 
            // chart_G_Original
            // 
            this.chart_G_Original.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chart_G_Original.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart_G_Original.Legends.Add(legend2);
            this.chart_G_Original.Location = new System.Drawing.Point(492, 373);
            this.chart_G_Original.Name = "chart_G_Original";
            this.chart_G_Original.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart_G_Original.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Green};
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "G";
            this.chart_G_Original.Series.Add(series2);
            this.chart_G_Original.Size = new System.Drawing.Size(353, 145);
            this.chart_G_Original.TabIndex = 7;
            this.chart_G_Original.Text = "G";
            // 
            // chart_B_Original
            // 
            this.chart_B_Original.BackColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.chart_B_Original.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart_B_Original.Legends.Add(legend3);
            this.chart_B_Original.Location = new System.Drawing.Point(492, 538);
            this.chart_B_Original.Name = "chart_B_Original";
            this.chart_B_Original.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart_B_Original.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Blue};
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "B";
            this.chart_B_Original.Series.Add(series3);
            this.chart_B_Original.Size = new System.Drawing.Size(353, 152);
            this.chart_B_Original.TabIndex = 8;
            this.chart_B_Original.Text = "B";
            // 
            // chart_P_Original
            // 
            this.chart_P_Original.BackColor = System.Drawing.Color.Transparent;
            chartArea4.Name = "ChartArea1";
            this.chart_P_Original.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart_P_Original.Legends.Add(legend4);
            this.chart_P_Original.Location = new System.Drawing.Point(492, 25);
            this.chart_P_Original.Name = "chart_P_Original";
            this.chart_P_Original.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart_P_Original.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black};
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "P";
            this.chart_P_Original.Series.Add(series4);
            this.chart_P_Original.Size = new System.Drawing.Size(353, 148);
            this.chart_P_Original.TabIndex = 9;
            this.chart_P_Original.Text = "P";
            // 
            // chart_P_Equalizado
            // 
            this.chart_P_Equalizado.BackColor = System.Drawing.Color.Transparent;
            chartArea5.Name = "ChartArea1";
            this.chart_P_Equalizado.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart_P_Equalizado.Legends.Add(legend5);
            this.chart_P_Equalizado.Location = new System.Drawing.Point(906, 25);
            this.chart_P_Equalizado.Name = "chart_P_Equalizado";
            this.chart_P_Equalizado.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart_P_Equalizado.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black};
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "P";
            this.chart_P_Equalizado.Series.Add(series5);
            this.chart_P_Equalizado.Size = new System.Drawing.Size(352, 148);
            this.chart_P_Equalizado.TabIndex = 13;
            this.chart_P_Equalizado.Text = "P";
            // 
            // chart_B_Equalizado
            // 
            this.chart_B_Equalizado.BackColor = System.Drawing.Color.Transparent;
            chartArea6.Name = "ChartArea1";
            this.chart_B_Equalizado.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart_B_Equalizado.Legends.Add(legend6);
            this.chart_B_Equalizado.Location = new System.Drawing.Point(906, 538);
            this.chart_B_Equalizado.Name = "chart_B_Equalizado";
            this.chart_B_Equalizado.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart_B_Equalizado.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Blue};
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "B";
            this.chart_B_Equalizado.Series.Add(series6);
            this.chart_B_Equalizado.Size = new System.Drawing.Size(352, 152);
            this.chart_B_Equalizado.TabIndex = 12;
            this.chart_B_Equalizado.Text = "B";
            // 
            // chart_G_Equalizado
            // 
            this.chart_G_Equalizado.BackColor = System.Drawing.Color.Transparent;
            chartArea7.Name = "ChartArea1";
            this.chart_G_Equalizado.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chart_G_Equalizado.Legends.Add(legend7);
            this.chart_G_Equalizado.Location = new System.Drawing.Point(906, 382);
            this.chart_G_Equalizado.Name = "chart_G_Equalizado";
            this.chart_G_Equalizado.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart_G_Equalizado.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Green};
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "G";
            this.chart_G_Equalizado.Series.Add(series7);
            this.chart_G_Equalizado.Size = new System.Drawing.Size(352, 145);
            this.chart_G_Equalizado.TabIndex = 11;
            this.chart_G_Equalizado.Text = "G";
            // 
            // chart_R_Equalizado
            // 
            this.chart_R_Equalizado.BackColor = System.Drawing.Color.Transparent;
            chartArea8.Name = "ChartArea1";
            this.chart_R_Equalizado.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chart_R_Equalizado.Legends.Add(legend8);
            this.chart_R_Equalizado.Location = new System.Drawing.Point(906, 197);
            this.chart_R_Equalizado.Name = "chart_R_Equalizado";
            this.chart_R_Equalizado.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart_R_Equalizado.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red};
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "R";
            this.chart_R_Equalizado.Series.Add(series8);
            this.chart_R_Equalizado.Size = new System.Drawing.Size(352, 154);
            this.chart_R_Equalizado.TabIndex = 10;
            this.chart_R_Equalizado.Text = "R";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1322, 712);
            this.Controls.Add(this.chart_P_Equalizado);
            this.Controls.Add(this.chart_B_Equalizado);
            this.Controls.Add(this.chart_G_Equalizado);
            this.Controls.Add(this.chart_R_Equalizado);
            this.Controls.Add(this.chart_P_Original);
            this.Controls.Add(this.chart_B_Original);
            this.Controls.Add(this.chart_G_Original);
            this.Controls.Add(this.chart_R_Original);
            this.Controls.Add(this.cmdEqualizarCores);
            this.Controls.Add(this.imagemEqualizada);
            this.Controls.Add(this.imagemOriginal);
            this.Controls.Add(this.cmdSalvar);
            this.Controls.Add(this.cmdEqualizar);
            this.Controls.Add(this.cmdAbrir);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equalização de Histograma";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.imagemOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagemEqualizada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_R_Original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_G_Original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_B_Original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_P_Original)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_P_Equalizado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_B_Equalizado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_G_Equalizado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_R_Equalizado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdAbrir;
        private System.Windows.Forms.Button cmdEqualizar;
        private System.Windows.Forms.Button cmdSalvar;
        private System.Windows.Forms.PictureBox imagemOriginal;
        private System.Windows.Forms.PictureBox imagemEqualizada;
        private System.Windows.Forms.Button cmdEqualizarCores;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_R_Original;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_G_Original;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_B_Original;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_P_Original;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_P_Equalizado;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_B_Equalizado;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_G_Equalizado;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_R_Equalizado;
    }
}


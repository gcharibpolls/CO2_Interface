namespace CO2_Interface
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SerialPort = new System.IO.Ports.SerialPort(this.components);
            this.COM_Button = new System.Windows.Forms.Button();
            this.DataTreatmen_Button = new System.Windows.Forms.Button();
            this.ObjectsGrid = new System.Windows.Forms.DataGridView();
            this.Connexion_Label = new System.Windows.Forms.Label();
            this.ConnexionStatus_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ObjectsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SerialPort
            // 
            this.SerialPort.PortName = "COM2";
            // 
            // COM_Button
            // 
            this.COM_Button.Location = new System.Drawing.Point(32, 23);
            this.COM_Button.Name = "COM_Button";
            this.COM_Button.Size = new System.Drawing.Size(164, 50);
            this.COM_Button.TabIndex = 0;
            this.COM_Button.Text = "ConnectToPort";
            this.COM_Button.UseVisualStyleBackColor = true;
            this.COM_Button.Click += new System.EventHandler(this.button_COM_Click);
            // 
            // DataTreatmen_Button
            // 
            this.DataTreatmen_Button.Location = new System.Drawing.Point(32, 79);
            this.DataTreatmen_Button.Name = "DataTreatmen_Button";
            this.DataTreatmen_Button.Size = new System.Drawing.Size(164, 50);
            this.DataTreatmen_Button.TabIndex = 1;
            this.DataTreatmen_Button.Text = "Data Treatment";
            this.DataTreatmen_Button.UseVisualStyleBackColor = true;
            this.DataTreatmen_Button.Click += new System.EventHandler(this.button_DataTreatment_Click);
            // 
            // ObjectsGrid
            // 
            this.ObjectsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ObjectsGrid.Location = new System.Drawing.Point(213, 23);
            this.ObjectsGrid.Name = "ObjectsGrid";
            this.ObjectsGrid.RowHeadersWidth = 51;
            this.ObjectsGrid.RowTemplate.Height = 24;
            this.ObjectsGrid.Size = new System.Drawing.Size(1083, 533);
            this.ObjectsGrid.TabIndex = 2;
            // 
            // Connexion_Label
            // 
            this.Connexion_Label.AutoSize = true;
            this.Connexion_Label.Location = new System.Drawing.Point(2, 173);
            this.Connexion_Label.Name = "Connexion_Label";
            this.Connexion_Label.Size = new System.Drawing.Size(116, 16);
            this.Connexion_Label.TabIndex = 3;
            this.Connexion_Label.Text = "Connexion Status: ";
            // 
            // ConnexionStatus_Label
            // 
            this.ConnexionStatus_Label.AutoSize = true;
            this.ConnexionStatus_Label.Location = new System.Drawing.Point(135, 173);
            this.ConnexionStatus_Label.Name = "ConnexionStatus_Label";
            this.ConnexionStatus_Label.Size = new System.Drawing.Size(42, 16);
            this.ConnexionStatus_Label.TabIndex = 4;
            this.ConnexionStatus_Label.Text = "Close";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 568);
            this.Controls.Add(this.ConnexionStatus_Label);
            this.Controls.Add(this.Connexion_Label);
            this.Controls.Add(this.ObjectsGrid);
            this.Controls.Add(this.DataTreatmen_Button);
            this.Controls.Add(this.COM_Button);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.ObjectsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.IO.Ports.SerialPort SerialPort;
        private System.Windows.Forms.Button COM_Button;
        private System.Windows.Forms.Button DataTreatmen_Button;
        private System.Windows.Forms.DataGridView ObjectsGrid;
        private System.Windows.Forms.Label Connexion_Label;
        private System.Windows.Forms.Label ConnexionStatus_Label;
    }
}


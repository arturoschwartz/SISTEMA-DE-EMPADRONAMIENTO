namespace pregistro.Formas
{
    partial class Frmreporte
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
            this.components = new System.ComponentModel.Container();
            this.vehiculosDataSet = new pregistro.vehiculosDataSet();
            this.matriculaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.matriculaTableAdapter = new pregistro.vehiculosDataSetTableAdapters.matriculaTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matriculaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // vehiculosDataSet
            // 
            this.vehiculosDataSet.DataSetName = "vehiculosDataSet";
            this.vehiculosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // matriculaBindingSource
            // 
            this.matriculaBindingSource.DataMember = "matricula";
            this.matriculaBindingSource.DataSource = this.vehiculosDataSet;
            // 
            // matriculaTableAdapter
            // 
            this.matriculaTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(524, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Frmreporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 784);
            this.Controls.Add(this.button1);
            this.Name = "Frmreporte";
            this.Text = "Rportes";
            this.Load += new System.EventHandler(this.Frmreporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vehiculosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matriculaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private vehiculosDataSet vehiculosDataSet;
        private System.Windows.Forms.BindingSource matriculaBindingSource;
        private vehiculosDataSetTableAdapters.matriculaTableAdapter matriculaTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}
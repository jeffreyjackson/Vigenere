using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
namespace JeffreyJackson.proj1
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class frmVigenereAlgorithm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mnuMain;
		private System.Windows.Forms.MenuItem mnuFile;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.GroupBox gbSumOfSquares;
		private System.Windows.Forms.Label lblKeyLength_SS;
		private System.Windows.Forms.Label lblKeyTitle_SS;
		private System.Windows.Forms.Button btnDecrypt_SS;
		private System.Windows.Forms.GroupBox gbSumAbsoluteDifferences;
		private System.Windows.Forms.Label lblKey_SAD;
		private System.Windows.Forms.Label lblKeyLength_SAD;
		private System.Windows.Forms.Label lblKeyTitle_SAD;
		private System.Windows.Forms.Button btnDecrypt_SAD;
		private System.Windows.Forms.GroupBox gbDotProduct;
		private System.Windows.Forms.Button btnDecrypt_DP;
		private System.Windows.Forms.Label lblKeyTitle_DP;
		private System.Windows.Forms.Label lblKey_DP;
		private System.Windows.Forms.Label lblKeyLength_DP;
		private System.Windows.Forms.ListBox lstCoincidences;
		private System.Windows.Forms.Label lblCoincidences;
		private System.Windows.Forms.Label lblCipherText;
		private System.Windows.Forms.Label lblPlainText;
		private System.Windows.Forms.TextBox txtCipherText;
		private System.Windows.Forms.TextBox txtPlainText;
		private System.Windows.Forms.Label lblKey_SS;
		private System.Windows.Forms.Button btnDecrypt;
		private System.Windows.Forms.Button btnEncrypt;
		private System.Windows.Forms.MenuItem mnuOpenCipherText;
		private System.Windows.Forms.MenuItem mnuOpenPlainText;
		private System.Windows.Forms.TextBox txtKey_Decrypt;
		private System.Windows.Forms.TextBox txtKey_Encrypt;
		private System.Windows.Forms.Label lblProbableKeyLength_SS;
		private System.Windows.Forms.Label lblProbableKeyLength_SAD;
		private System.Windows.Forms.Label lblProbableKeyLength_DP;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Label lblDecrypt;
		private System.Windows.Forms.Label lblEncryptToFile;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmVigenereAlgorithm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmVigenereAlgorithm));
			this.mnuMain = new System.Windows.Forms.MainMenu();
			this.mnuFile = new System.Windows.Forms.MenuItem();
			this.mnuOpenCipherText = new System.Windows.Forms.MenuItem();
			this.mnuOpenPlainText = new System.Windows.Forms.MenuItem();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.gbSumOfSquares = new System.Windows.Forms.GroupBox();
			this.lblProbableKeyLength_SS = new System.Windows.Forms.Label();
			this.lblKey_SS = new System.Windows.Forms.Label();
			this.lblKeyLength_SS = new System.Windows.Forms.Label();
			this.lblKeyTitle_SS = new System.Windows.Forms.Label();
			this.btnDecrypt_SS = new System.Windows.Forms.Button();
			this.gbSumAbsoluteDifferences = new System.Windows.Forms.GroupBox();
			this.lblProbableKeyLength_SAD = new System.Windows.Forms.Label();
			this.lblKey_SAD = new System.Windows.Forms.Label();
			this.lblKeyLength_SAD = new System.Windows.Forms.Label();
			this.lblKeyTitle_SAD = new System.Windows.Forms.Label();
			this.btnDecrypt_SAD = new System.Windows.Forms.Button();
			this.gbDotProduct = new System.Windows.Forms.GroupBox();
			this.lblProbableKeyLength_DP = new System.Windows.Forms.Label();
			this.btnDecrypt_DP = new System.Windows.Forms.Button();
			this.lblKeyTitle_DP = new System.Windows.Forms.Label();
			this.lblKey_DP = new System.Windows.Forms.Label();
			this.lblKeyLength_DP = new System.Windows.Forms.Label();
			this.lstCoincidences = new System.Windows.Forms.ListBox();
			this.lblCoincidences = new System.Windows.Forms.Label();
			this.lblCipherText = new System.Windows.Forms.Label();
			this.lblPlainText = new System.Windows.Forms.Label();
			this.txtCipherText = new System.Windows.Forms.TextBox();
			this.txtPlainText = new System.Windows.Forms.TextBox();
			this.btnDecrypt = new System.Windows.Forms.Button();
			this.btnEncrypt = new System.Windows.Forms.Button();
			this.txtKey_Decrypt = new System.Windows.Forms.TextBox();
			this.txtKey_Encrypt = new System.Windows.Forms.TextBox();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.lblDecrypt = new System.Windows.Forms.Label();
			this.lblEncryptToFile = new System.Windows.Forms.Label();
			this.gbSumOfSquares.SuspendLayout();
			this.gbSumAbsoluteDifferences.SuspendLayout();
			this.gbDotProduct.SuspendLayout();
			this.SuspendLayout();
			// 
			// mnuMain
			// 
			this.mnuMain.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					this.mnuFile});
			// 
			// mnuFile
			// 
			this.mnuFile.Index = 0;
			this.mnuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					this.mnuOpenCipherText,
																					this.mnuOpenPlainText});
			this.mnuFile.Text = "File";
			// 
			// mnuOpenCipherText
			// 
			this.mnuOpenCipherText.Index = 0;
			this.mnuOpenCipherText.Text = "Open CipherText...";
			this.mnuOpenCipherText.Click += new System.EventHandler(this.mnuOpenCipherText_Click);
			// 
			// mnuOpenPlainText
			// 
			this.mnuOpenPlainText.Index = 1;
			this.mnuOpenPlainText.Text = "Open PlainText...";
			this.mnuOpenPlainText.Click += new System.EventHandler(this.mnuOpenPlainText_Click);
			// 
			// gbSumOfSquares
			// 
			this.gbSumOfSquares.Controls.Add(this.lblProbableKeyLength_SS);
			this.gbSumOfSquares.Controls.Add(this.lblKey_SS);
			this.gbSumOfSquares.Controls.Add(this.lblKeyLength_SS);
			this.gbSumOfSquares.Controls.Add(this.lblKeyTitle_SS);
			this.gbSumOfSquares.Controls.Add(this.btnDecrypt_SS);
			this.gbSumOfSquares.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.gbSumOfSquares.Location = new System.Drawing.Point(144, 360);
			this.gbSumOfSquares.Name = "gbSumOfSquares";
			this.gbSumOfSquares.Size = new System.Drawing.Size(664, 96);
			this.gbSumOfSquares.TabIndex = 13;
			this.gbSumOfSquares.TabStop = false;
			this.gbSumOfSquares.Text = "Sum of Squares Method";
			// 
			// lblProbableKeyLength_SS
			// 
			this.lblProbableKeyLength_SS.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblProbableKeyLength_SS.Location = new System.Drawing.Point(16, 24);
			this.lblProbableKeyLength_SS.Name = "lblProbableKeyLength_SS";
			this.lblProbableKeyLength_SS.Size = new System.Drawing.Size(120, 23);
			this.lblProbableKeyLength_SS.TabIndex = 17;
			this.lblProbableKeyLength_SS.Text = "Key Length";
			this.lblProbableKeyLength_SS.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// lblKey_SS
			// 
			this.lblKey_SS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblKey_SS.Location = new System.Drawing.Point(176, 56);
			this.lblKey_SS.Name = "lblKey_SS";
			this.lblKey_SS.Size = new System.Drawing.Size(400, 24);
			this.lblKey_SS.TabIndex = 16;
			this.lblKey_SS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblKeyLength_SS
			// 
			this.lblKeyLength_SS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblKeyLength_SS.Location = new System.Drawing.Point(24, 56);
			this.lblKeyLength_SS.Name = "lblKeyLength_SS";
			this.lblKeyLength_SS.TabIndex = 15;
			this.lblKeyLength_SS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblKeyTitle_SS
			// 
			this.lblKeyTitle_SS.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblKeyTitle_SS.Location = new System.Drawing.Point(312, 24);
			this.lblKeyTitle_SS.Name = "lblKeyTitle_SS";
			this.lblKeyTitle_SS.Size = new System.Drawing.Size(128, 24);
			this.lblKeyTitle_SS.TabIndex = 14;
			this.lblKeyTitle_SS.Text = "Probable Key";
			// 
			// btnDecrypt_SS
			// 
			this.btnDecrypt_SS.Image = ((System.Drawing.Image)(resources.GetObject("btnDecrypt_SS.Image")));
			this.btnDecrypt_SS.Location = new System.Drawing.Point(592, 24);
			this.btnDecrypt_SS.Name = "btnDecrypt_SS";
			this.btnDecrypt_SS.Size = new System.Drawing.Size(56, 56);
			this.btnDecrypt_SS.TabIndex = 0;
			this.btnDecrypt_SS.Click += new System.EventHandler(this.btnDecrypt_SS_Click);
			// 
			// gbSumAbsoluteDifferences
			// 
			this.gbSumAbsoluteDifferences.Controls.Add(this.lblProbableKeyLength_SAD);
			this.gbSumAbsoluteDifferences.Controls.Add(this.lblKey_SAD);
			this.gbSumAbsoluteDifferences.Controls.Add(this.lblKeyLength_SAD);
			this.gbSumAbsoluteDifferences.Controls.Add(this.lblKeyTitle_SAD);
			this.gbSumAbsoluteDifferences.Controls.Add(this.btnDecrypt_SAD);
			this.gbSumAbsoluteDifferences.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.gbSumAbsoluteDifferences.Location = new System.Drawing.Point(144, 256);
			this.gbSumAbsoluteDifferences.Name = "gbSumAbsoluteDifferences";
			this.gbSumAbsoluteDifferences.Size = new System.Drawing.Size(664, 96);
			this.gbSumAbsoluteDifferences.TabIndex = 12;
			this.gbSumAbsoluteDifferences.TabStop = false;
			this.gbSumAbsoluteDifferences.Text = "Sum Absolute Differences Method";
			// 
			// lblProbableKeyLength_SAD
			// 
			this.lblProbableKeyLength_SAD.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblProbableKeyLength_SAD.Location = new System.Drawing.Point(16, 24);
			this.lblProbableKeyLength_SAD.Name = "lblProbableKeyLength_SAD";
			this.lblProbableKeyLength_SAD.Size = new System.Drawing.Size(120, 23);
			this.lblProbableKeyLength_SAD.TabIndex = 18;
			this.lblProbableKeyLength_SAD.Text = "Key Length";
			this.lblProbableKeyLength_SAD.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// lblKey_SAD
			// 
			this.lblKey_SAD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblKey_SAD.Location = new System.Drawing.Point(176, 56);
			this.lblKey_SAD.Name = "lblKey_SAD";
			this.lblKey_SAD.Size = new System.Drawing.Size(400, 24);
			this.lblKey_SAD.TabIndex = 16;
			this.lblKey_SAD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblKeyLength_SAD
			// 
			this.lblKeyLength_SAD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblKeyLength_SAD.Location = new System.Drawing.Point(24, 56);
			this.lblKeyLength_SAD.Name = "lblKeyLength_SAD";
			this.lblKeyLength_SAD.TabIndex = 15;
			this.lblKeyLength_SAD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblKeyTitle_SAD
			// 
			this.lblKeyTitle_SAD.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblKeyTitle_SAD.Location = new System.Drawing.Point(312, 24);
			this.lblKeyTitle_SAD.Name = "lblKeyTitle_SAD";
			this.lblKeyTitle_SAD.Size = new System.Drawing.Size(128, 24);
			this.lblKeyTitle_SAD.TabIndex = 14;
			this.lblKeyTitle_SAD.Text = "Probable Key";
			// 
			// btnDecrypt_SAD
			// 
			this.btnDecrypt_SAD.Image = ((System.Drawing.Image)(resources.GetObject("btnDecrypt_SAD.Image")));
			this.btnDecrypt_SAD.Location = new System.Drawing.Point(592, 24);
			this.btnDecrypt_SAD.Name = "btnDecrypt_SAD";
			this.btnDecrypt_SAD.Size = new System.Drawing.Size(56, 56);
			this.btnDecrypt_SAD.TabIndex = 0;
			this.btnDecrypt_SAD.Click += new System.EventHandler(this.btnDecrypt_SAD_Click);
			// 
			// gbDotProduct
			// 
			this.gbDotProduct.Controls.Add(this.lblProbableKeyLength_DP);
			this.gbDotProduct.Controls.Add(this.btnDecrypt_DP);
			this.gbDotProduct.Controls.Add(this.lblKeyTitle_DP);
			this.gbDotProduct.Controls.Add(this.lblKey_DP);
			this.gbDotProduct.Controls.Add(this.lblKeyLength_DP);
			this.gbDotProduct.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.gbDotProduct.Location = new System.Drawing.Point(144, 152);
			this.gbDotProduct.Name = "gbDotProduct";
			this.gbDotProduct.Size = new System.Drawing.Size(664, 96);
			this.gbDotProduct.TabIndex = 11;
			this.gbDotProduct.TabStop = false;
			this.gbDotProduct.Text = "Dot Product Method";
			// 
			// lblProbableKeyLength_DP
			// 
			this.lblProbableKeyLength_DP.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblProbableKeyLength_DP.Location = new System.Drawing.Point(16, 24);
			this.lblProbableKeyLength_DP.Name = "lblProbableKeyLength_DP";
			this.lblProbableKeyLength_DP.Size = new System.Drawing.Size(120, 23);
			this.lblProbableKeyLength_DP.TabIndex = 15;
			this.lblProbableKeyLength_DP.Text = "Key Length";
			this.lblProbableKeyLength_DP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// btnDecrypt_DP
			// 
			this.btnDecrypt_DP.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnDecrypt_DP.Image = ((System.Drawing.Image)(resources.GetObject("btnDecrypt_DP.Image")));
			this.btnDecrypt_DP.Location = new System.Drawing.Point(592, 24);
			this.btnDecrypt_DP.Name = "btnDecrypt_DP";
			this.btnDecrypt_DP.Size = new System.Drawing.Size(56, 56);
			this.btnDecrypt_DP.TabIndex = 14;
			this.btnDecrypt_DP.Click += new System.EventHandler(this.btnDecrypt_DP_Click);
			// 
			// lblKeyTitle_DP
			// 
			this.lblKeyTitle_DP.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblKeyTitle_DP.Location = new System.Drawing.Point(308, 20);
			this.lblKeyTitle_DP.Name = "lblKeyTitle_DP";
			this.lblKeyTitle_DP.Size = new System.Drawing.Size(128, 24);
			this.lblKeyTitle_DP.TabIndex = 13;
			this.lblKeyTitle_DP.Text = "Probable Key";
			// 
			// lblKey_DP
			// 
			this.lblKey_DP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblKey_DP.Location = new System.Drawing.Point(176, 52);
			this.lblKey_DP.Name = "lblKey_DP";
			this.lblKey_DP.Size = new System.Drawing.Size(400, 24);
			this.lblKey_DP.TabIndex = 12;
			this.lblKey_DP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblKeyLength_DP
			// 
			this.lblKeyLength_DP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblKeyLength_DP.Location = new System.Drawing.Point(24, 52);
			this.lblKeyLength_DP.Name = "lblKeyLength_DP";
			this.lblKeyLength_DP.TabIndex = 11;
			this.lblKeyLength_DP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lstCoincidences
			// 
			this.lstCoincidences.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lstCoincidences.ItemHeight = 18;
			this.lstCoincidences.Location = new System.Drawing.Point(8, 168);
			this.lstCoincidences.Name = "lstCoincidences";
			this.lstCoincidences.Size = new System.Drawing.Size(120, 292);
			this.lstCoincidences.TabIndex = 0;
			this.lstCoincidences.SelectedIndexChanged += new System.EventHandler(this.lstCoincidences_SelectedIndexChanged);
			// 
			// lblCoincidences
			// 
			this.lblCoincidences.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblCoincidences.Location = new System.Drawing.Point(4, 144);
			this.lblCoincidences.Name = "lblCoincidences";
			this.lblCoincidences.Size = new System.Drawing.Size(128, 23);
			this.lblCoincidences.TabIndex = 3;
			this.lblCoincidences.Text = "Coincidences";
			this.lblCoincidences.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// lblCipherText
			// 
			this.lblCipherText.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblCipherText.Location = new System.Drawing.Point(8, 8);
			this.lblCipherText.Name = "lblCipherText";
			this.lblCipherText.Size = new System.Drawing.Size(112, 23);
			this.lblCipherText.TabIndex = 4;
			this.lblCipherText.Text = "Cipher Text";
			this.lblCipherText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lblPlainText
			// 
			this.lblPlainText.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblPlainText.Location = new System.Drawing.Point(8, 464);
			this.lblPlainText.Name = "lblPlainText";
			this.lblPlainText.TabIndex = 5;
			this.lblPlainText.Text = "Plain Text";
			this.lblPlainText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// txtCipherText
			// 
			this.txtCipherText.Location = new System.Drawing.Point(8, 32);
			this.txtCipherText.Multiline = true;
			this.txtCipherText.Name = "txtCipherText";
			this.txtCipherText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtCipherText.Size = new System.Drawing.Size(544, 104);
			this.txtCipherText.TabIndex = 6;
			this.txtCipherText.Text = "";
			this.txtCipherText.TextChanged += new System.EventHandler(this.txtCipherText_TextChanged);
			// 
			// txtPlainText
			// 
			this.txtPlainText.Location = new System.Drawing.Point(8, 488);
			this.txtPlainText.Multiline = true;
			this.txtPlainText.Name = "txtPlainText";
			this.txtPlainText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtPlainText.Size = new System.Drawing.Size(544, 112);
			this.txtPlainText.TabIndex = 7;
			this.txtPlainText.Text = "";
			// 
			// btnDecrypt
			// 
			this.btnDecrypt.Image = ((System.Drawing.Image)(resources.GetObject("btnDecrypt.Image")));
			this.btnDecrypt.Location = new System.Drawing.Point(656, 80);
			this.btnDecrypt.Name = "btnDecrypt";
			this.btnDecrypt.Size = new System.Drawing.Size(56, 56);
			this.btnDecrypt.TabIndex = 14;
			this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
			// 
			// btnEncrypt
			// 
			this.btnEncrypt.Image = ((System.Drawing.Image)(resources.GetObject("btnEncrypt.Image")));
			this.btnEncrypt.Location = new System.Drawing.Point(656, 536);
			this.btnEncrypt.Name = "btnEncrypt";
			this.btnEncrypt.Size = new System.Drawing.Size(56, 56);
			this.btnEncrypt.TabIndex = 15;
			this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
			// 
			// txtKey_Decrypt
			// 
			this.txtKey_Decrypt.Location = new System.Drawing.Point(564, 32);
			this.txtKey_Decrypt.Name = "txtKey_Decrypt";
			this.txtKey_Decrypt.Size = new System.Drawing.Size(240, 20);
			this.txtKey_Decrypt.TabIndex = 16;
			this.txtKey_Decrypt.Text = "";
			this.txtKey_Decrypt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtKey_Encrypt
			// 
			this.txtKey_Encrypt.Location = new System.Drawing.Point(560, 488);
			this.txtKey_Encrypt.Name = "txtKey_Encrypt";
			this.txtKey_Encrypt.Size = new System.Drawing.Size(248, 20);
			this.txtKey_Encrypt.TabIndex = 17;
			this.txtKey_Encrypt.Text = "";
			this.txtKey_Encrypt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblDecrypt
			// 
			this.lblDecrypt.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblDecrypt.Location = new System.Drawing.Point(648, 56);
			this.lblDecrypt.Name = "lblDecrypt";
			this.lblDecrypt.Size = new System.Drawing.Size(80, 24);
			this.lblDecrypt.TabIndex = 18;
			this.lblDecrypt.Text = "Decrypt";
			// 
			// lblEncryptToFile
			// 
			this.lblEncryptToFile.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lblEncryptToFile.Location = new System.Drawing.Point(608, 512);
			this.lblEncryptToFile.Name = "lblEncryptToFile";
			this.lblEncryptToFile.Size = new System.Drawing.Size(152, 24);
			this.lblEncryptToFile.TabIndex = 19;
			this.lblEncryptToFile.Text = "Encrypt to File...";
			// 
			// frmVigenereAlgorithm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(816, 609);
			this.Controls.Add(this.lblEncryptToFile);
			this.Controls.Add(this.lblDecrypt);
			this.Controls.Add(this.txtKey_Encrypt);
			this.Controls.Add(this.txtKey_Decrypt);
			this.Controls.Add(this.btnEncrypt);
			this.Controls.Add(this.btnDecrypt);
			this.Controls.Add(this.gbSumOfSquares);
			this.Controls.Add(this.gbSumAbsoluteDifferences);
			this.Controls.Add(this.gbDotProduct);
			this.Controls.Add(this.lstCoincidences);
			this.Controls.Add(this.lblCoincidences);
			this.Controls.Add(this.lblCipherText);
			this.Controls.Add(this.lblPlainText);
			this.Controls.Add(this.txtCipherText);
			this.Controls.Add(this.txtPlainText);
			this.MaximizeBox = false;
			this.Menu = this.mnuMain;
			this.Name = "frmVigenereAlgorithm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Vigenere Algorithm";
			this.gbSumOfSquares.ResumeLayout(false);
			this.gbSumAbsoluteDifferences.ResumeLayout(false);
			this.gbDotProduct.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new frmVigenereAlgorithm());
		}

		public double[] GetEnglishVector(int intShift)
		{
			double[] dblArrayEnglishFrequency = new double[26];
			switch(intShift)
			{
				case 0:
					dblArrayEnglishFrequency = new double[26] {.082,.015,.028,.043,.127,.022,.020,.061,.070,.002,.008,.040,.024,.067,.075,.019,.001,.060,.063,.091,.028,.010,.023,.001,.020,.001};
					break;
				case 1:
					dblArrayEnglishFrequency = new double[26] {.001,.082,.015,.028,.043,.127,.022,.020,.061,.070,.002,.008,.040,.024,.067,.075,.019,.001,.060,.063,.091,.028,.010,.023,.001,.020};
					break;
				case 2:
					dblArrayEnglishFrequency = new double[26] {.020,.001,.082,.015,.028,.043,.127,.022,.020,.061,.070,.002,.008,.040,.024,.067,.075,.019,.001,.060,.063,.091,.028,.010,.023,.001};
					break;
				case 3:
					dblArrayEnglishFrequency = new double[26] {.001,.020,.001,.082,.015,.028,.043,.127,.022,.020,.061,.070,.002,.008,.040,.024,.067,.075,.019,.001,.060,.063,.091,.028,.010,.023};
					break;
				case 4:
					dblArrayEnglishFrequency = new double[26] {.023,.001,.020,.001,.082,.015,.028,.043,.127,.022,.020,.061,.070,.002,.008,.040,.024,.067,.075,.019,.001,.060,.063,.091,.028,.010};
					break;
				case 5:
					dblArrayEnglishFrequency = new double[26] {.010,.023,.001,.020,.001,.082,.015,.028,.043,.127,.022,.020,.061,.070,.002,.008,.040,.024,.067,.075,.019,.001,.060,.063,.091,.028};
					break;
				case 6:
					dblArrayEnglishFrequency = new double[26] {.028,.010,.023,.001,.020,.001,.082,.015,.028,.043,.127,.022,.020,.061,.070,.002,.008,.040,.024,.067,.075,.019,.001,.060,.063,.091};
					break;
				case 7:
					dblArrayEnglishFrequency = new double[26] {.091,.028,.010,.023,.001,.020,.001,.082,.015,.028,.043,.127,.022,.020,.061,.070,.002,.008,.040,.024,.067,.075,.019,.001,.060,.063};
					break;
				case 8:
					dblArrayEnglishFrequency = new double[26] {.063,.091,.028,.010,.023,.001,.020,.001,.082,.015,.028,.043,.127,.022,.020,.061,.070,.002,.008,.040,.024,.067,.075,.019,.001,.060};
					break;
				case 9:
					dblArrayEnglishFrequency = new double[26] {.060,.063,.091,.028,.010,.023,.001,.020,.001,.082,.015,.028,.043,.127,.022,.020,.061,.070,.002,.008,.040,.024,.067,.075,.019,.001};
					break;
				case 10:
					dblArrayEnglishFrequency = new double[26] {.001,.060,.063,.091,.028,.010,.023,.001,.020,.001,.082,.015,.028,.043,.127,.022,.020,.061,.070,.002,.008,.040,.024,.067,.075,.019};
					break;
				case 11:
					dblArrayEnglishFrequency = new double[26] {.019,.001,.060,.063,.091,.028,.010,.023,.001,.020,.001,.082,.015,.028,.043,.127,.022,.020,.061,.070,.002,.008,.040,.024,.067,.075};
					break;
				case 12:
					dblArrayEnglishFrequency = new double[26] {.075,.019,.001,.060,.063,.091,.028,.010,.023,.001,.020,.001,.082,.015,.028,.043,.127,.022,.020,.061,.070,.002,.008,.040,.024,.067};
					break;
				case 13:
					dblArrayEnglishFrequency = new double[26] {.067,.075,.019,.001,.060,.063,.091,.028,.010,.023,.001,.020,.001,.082,.015,.028,.043,.127,.022,.020,.061,.070,.002,.008,.040,.024};
					break;
				case 14:
					dblArrayEnglishFrequency = new double[26] {.024,.067,.075,.019,.001,.060,.063,.091,.028,.010,.023,.001,.020,.001,.082,.015,.028,.043,.127,.022,.020,.061,.070,.002,.008,.040};
					break;
				case 15:
					dblArrayEnglishFrequency = new double[26] {.040,.024,.067,.075,.019,.001,.060,.063,.091,.028,.010,.023,.001,.020,.001,.082,.015,.028,.043,.127,.022,.020,.061,.070,.002,.008};
					break;
				case 16:
					dblArrayEnglishFrequency = new double[26] {.008,.040,.024,.067,.075,.019,.001,.060,.063,.091,.028,.010,.023,.001,.020,.001,.082,.015,.028,.043,.127,.022,.020,.061,.070,.002};
					break;
				case 17:
					dblArrayEnglishFrequency = new double[26] {.002,.008,.040,.024,.067,.075,.019,.001,.060,.063,.091,.028,.010,.023,.001,.020,.001,.082,.015,.028,.043,.127,.022,.020,.061,.070};
					break;
				case 18:
					dblArrayEnglishFrequency = new double[26] {.070,.002,.008,.040,.024,.067,.075,.019,.001,.060,.063,.091,.028,.010,.023,.001,.020,.001,.082,.015,.028,.043,.127,.022,.020,.061};
					break;
				case 19:
					dblArrayEnglishFrequency = new double[26] {.061,.070,.002,.008,.040,.024,.067,.075,.019,.001,.060,.063,.091,.028,.010,.023,.001,.020,.001,.082,.015,.028,.043,.127,.022,.020};
					break;
				case 20:
					dblArrayEnglishFrequency = new double[26] {.020,.061,.070,.002,.008,.040,.024,.067,.075,.019,.001,.060,.063,.091,.028,.010,.023,.001,.020,.001,.082,.015,.028,.043,.127,.022};
					break;
				case 21:
					dblArrayEnglishFrequency = new double[26] {.022,.020,.061,.070,.002,.008,.040,.024,.067,.075,.019,.001,.060,.063,.091,.028,.010,.023,.001,.020,.001,.082,.015,.028,.043,.127};
					break;
				case 22:
					dblArrayEnglishFrequency = new double[26] {.127,.022,.020,.061,.070,.002,.008,.040,.024,.067,.075,.019,.001,.060,.063,.091,.028,.010,.023,.001,.020,.001,.082,.015,.028,.043};
					break;
				case 23:
					dblArrayEnglishFrequency = new double[26] {.043,.127,.022,.020,.061,.070,.002,.008,.040,.024,.067,.075,.019,.001,.060,.063,.091,.028,.010,.023,.001,.020,.001,.082,.015,.028};
					break;
				case 24:
					dblArrayEnglishFrequency = new double[26] {.028,.043,.127,.022,.020,.061,.070,.002,.008,.040,.024,.067,.075,.019,.001,.060,.063,.091,.028,.010,.023,.001,.020,.001,.082,.015};
					break;
				case 25:
					dblArrayEnglishFrequency = new double[26] {.015,.028,.043,.127,.022,.020,.061,.070,.002,.008,.040,.024,.067,.075,.019,.001,.060,.063,.091,.028,.010,.023,.001,.020,.001,.082};
					break;
			}	

			return dblArrayEnglishFrequency;
		}

		public char GetEnglishLetter(int i)
		{
			char chrReturn = ' ';

			switch(i)
			{
				case 0:
					chrReturn = 'a';
					break;
				case 1:
					chrReturn = 'b';
					break;
				case 2:
					chrReturn = 'c';
					break;
				case 3:
					chrReturn = 'd';
					break;
				case 4:
					chrReturn = 'e';
					break;
				case 5:
					chrReturn = 'f';
					break;
				case 6:
					chrReturn = 'g';
					break;
				case 7:
					chrReturn = 'h';
					break;
				case 8:
					chrReturn = 'i';
					break;
				case 9:
					chrReturn = 'j';
					break;
				case 10:
					chrReturn = 'k';
					break;
				case 11:
					chrReturn = 'l';
					break;
				case 12:
					chrReturn = 'm';
					break;
				case 13:
					chrReturn = 'n';
					break;
				case 14:
					chrReturn = 'o';
					break;
				case 15:
					chrReturn = 'p';
					break;
				case 16:
					chrReturn = 'q';
					break;
				case 17:
					chrReturn = 'r';
					break;
				case 18:
					chrReturn = 's';
					break;
				case 19:
					chrReturn = 't';
					break;
				case 20:
					chrReturn = 'u';
					break;
				case 21:
					chrReturn = 'v';
					break;
				case 22:
					chrReturn = 'w';
					break;
				case 23:
					chrReturn = 'x';
					break;
				case 24:
					chrReturn = 'y';
					break;
				case 25:
					chrReturn = 'z';
					break;
			}

			return chrReturn;
		}

		public int GetEnglishLetterIndex(char c)
		{
			int intReturn = 0;

			switch(c)
			{
				case 'a':
					intReturn = 0;
					break;
				case 'b':
					intReturn = 1;
					break;
				case 'c':
					intReturn = 2;
					break;
				case 'd':
					intReturn = 3;
					break;
				case 'e':
					intReturn = 4;
					break;
				case 'f':
					intReturn = 5;
					break;
				case 'g':
					intReturn = 6;
					break;
				case 'h':
					intReturn = 7;
					break;
				case 'i':
					intReturn = 8;
					break;
				case 'j':
					intReturn = 9;
					break;
				case 'k':
					intReturn = 10;
					break;
				case 'l':
					intReturn = 11;
					break;
				case 'm':
					intReturn = 12;
					break;
				case 'n':
					intReturn = 13;
					break;
				case 'o':
					intReturn = 14;
					break;
				case 'p':
					intReturn = 15;
					break;
				case 'q':
					intReturn = 16;
					break;
				case 'r':
					intReturn = 17;
					break;
				case 's':
					intReturn = 18;
					break;
				case 't':
					intReturn = 19;
					break;
				case 'u':
					intReturn = 20;
					break;
				case 'v':
					intReturn = 21;
					break;
				case 'w':
					intReturn = 22;
					break;
				case 'x':
					intReturn = 23;
					break;
				case 'y':
					intReturn = 24;
					break;
				case 'z':
					intReturn = 25;
					break;
			}
			return intReturn;
		}

		private void txtCipherText_TextChanged(object sender, System.EventArgs e)
		{
			char[] chrArrayInitial; 
			char[] chrArrayShift; 
			int[,] intShifts = new int[2,this.txtCipherText.TextLength];
			chrArrayInitial = this.txtCipherText.Text.ToString().ToCharArray();
			chrArrayShift = this.txtCipherText.Text.ToString().ToCharArray();
			
			if (this.txtCipherText.Text == "")
			{
				this.lstCoincidences.Items.Clear();
				this.lblKey_DP.Text = "";
				this.lblKey_SAD.Text = "";
				this.lblKey_SS.Text = "";
				this.lblKeyLength_DP.Text = "";
				this.lblKeyLength_SAD.Text = "";
				this.lblKeyLength_SS.Text = "";
			}
			else
			{
				for (int i =0; i<50;i++)
				{
					intShifts[0,i] = i;
					intShifts[1,i] = 0;
					for(int j=0;j<this.txtCipherText.TextLength-i;j++)
					{
						if(chrArrayInitial[i+j].ToString().Equals(chrArrayShift[j].ToString()))
						{
							intShifts[1,i] = intShifts[1,i] +1;
						}
					}
					if (i != 0) 
					{
						this.lstCoincidences.Items.Add(intShifts[1,i].ToString());
					}
				}
			}
		}

		private void lstCoincidences_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			char[] chrArrayCipherText;
			int intLetterIndex;
			int intShifts = 1 + lstCoincidences.SelectedIndex;
			this.lblKeyLength_DP.Text = intShifts.ToString();
			this.lblKeyLength_SS.Text = intShifts.ToString();
			this.lblKeyLength_SAD.Text = intShifts.ToString();
			double[,] dblWTables = new double[intShifts,26];
			double[,] dblDotProductTable = new double[intShifts,26];
			double[,] dblSADTable = new double[intShifts,26];
			double[,] dblSSTable = new double[intShifts,26];
			chrArrayCipherText = this.txtCipherText.Text.ToString().ToCharArray();
			double[] dblAVector = new double[26];
			double dblDotProduct;
			double dblSumSquares;
			double dblSumAbsoluteDifferences;
			double[,] dblGreatest = new double[2,intShifts];
			double[,] dblSmallest = new double[2,intShifts];
			
			this.lblKey_DP.Text = "";
			this.lblKey_SAD.Text = "";
			this.lblKey_SS.Text = "";

			for (int i=0;i<intShifts;i++)
			{
				for (int j=0+i;j<this.txtCipherText.TextLength;)
				{
					intLetterIndex = GetEnglishLetterIndex(chrArrayCipherText[j]);
					dblWTables[i,intLetterIndex] = dblWTables[i,intLetterIndex] + 0.038461538461538461538461538461538;
					j = j + intShifts;
				}
			}
			
			for (int i=0;i<intShifts;i++)
			{
				for (int j=0;j<26;j++)
				{
					dblAVector = GetEnglishVector(j);
					dblDotProduct = 0.0;
					for (int k=0;k<26;k++)
					{
						dblDotProduct = (dblWTables[i,k] * dblAVector[k]) + dblDotProduct;
					}
					dblDotProductTable[i,j] = dblDotProduct;
				}
			}

			for (int i=0;i<intShifts;i++)
			{
				for(int j=0;j<26;j++)
				{
					if (dblGreatest[1,i] < dblDotProductTable[i,j])
					{
						dblGreatest[0,i] = j;
						dblGreatest[1,i] = dblDotProductTable[i,j];
					}
				}
			}
			
			for (int i=0;i<intShifts;i++)
			{
				int intConvert = 0;
				intConvert = (int) dblGreatest[0,i];
				lblKey_DP.Text = lblKey_DP.Text.ToString() + GetEnglishLetter(intConvert);
			}

			for (int i=0;i<intShifts;i++)
			{
				for (int j=0;j<26;j++)
				{
					dblAVector = GetEnglishVector(j);
					dblSumSquares = 0.0;
					for (int k=0;k<26;k++)
					{
						dblSumSquares = ((dblWTables[i,k] - dblAVector[k])*(dblWTables[i,k] - dblAVector[k])) + dblSumSquares;
					}
					dblSSTable[i,j] = dblSumSquares;
				}
			}

			for (int i=0;i<intShifts;i++)
			{
				dblSmallest[0,i] = 100000.0;
				dblSmallest[1,i] = 100000.0;
				for (int j =0;j<26;j++)
				{
					if (dblSmallest[1,i] > dblSSTable[i,j])
					{
						dblSmallest[0,i] = j;
						dblSmallest[1,i] = dblSSTable[i,j];
					}
				}
			}

			for (int i =0;i<intShifts;i++)
			{
				int intConvert = 0;
				intConvert = (int) dblSmallest[0,i];
				lblKey_SS.Text = lblKey_SS.Text.ToString() + GetEnglishLetter(intConvert);
			}

			for (int i=0;i<intShifts;i++)
			{
				for (int j=0;j<26;j++)
				{
					dblAVector = GetEnglishVector(j);
					dblSumAbsoluteDifferences = 0.0;
					for (int k=0;k<26;k++)
					{
						if ((dblWTables[i,k] - dblAVector[k]) < 0)
						{
							dblSumAbsoluteDifferences = -1*(dblWTables[i,k] - dblAVector[k]) + dblSumAbsoluteDifferences;
						}
						else
						{
							dblSumAbsoluteDifferences = (dblWTables[i,k] - dblAVector[k]) + dblSumAbsoluteDifferences;
						}
					}
					dblSADTable[i,j] = dblSumAbsoluteDifferences;
				}
			}

			for (int i=0;i<intShifts;i++)
			{
				dblSmallest[0,i] = 100000.0;
				dblSmallest[1,i] = 100000.0;
				for (int j =0;j<26;j++)
				{
					if (dblSmallest[1,i] > dblSADTable[i,j])
					{
						dblSmallest[0,i] = j;
						dblSmallest[1,i] = dblSADTable[i,j];
					}
				}
			}

			for (int i =0;i<intShifts;i++)
			{
				int intConvert = 0;
				intConvert = (int) dblSmallest[0,i];
				lblKey_SAD.Text = lblKey_SAD.Text.ToString() + GetEnglishLetter(intConvert);
			}
		}

		private void mnuOpenPlainText_Click(object sender, System.EventArgs e)
		{
			string strIncomingFile = "";
			this.txtPlainText.Text = "";
			this.txtCipherText.Text = "";
			this.lblKey_DP.Text = "";
			this.lblKey_SAD.Text = "";
			this.lblKey_SS.Text = "";
			this.lblKeyLength_DP.Text = "";
			this.lblKeyLength_SAD.Text = "";
			this.lblKeyLength_SS.Text = "";

			if(openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				System.IO.StreamReader sr = new 
					System.IO.StreamReader(openFileDialog1.FileName);
				strIncomingFile = sr.ReadToEnd();
				sr.Close();
				strIncomingFile = strIncomingFile.Replace(" ","");
				strIncomingFile = strIncomingFile.Replace('\u000D'.ToString(),"");
				strIncomingFile = strIncomingFile.Replace('\u000A'.ToString(),"");
				strIncomingFile = strIncomingFile.ToLower();
				this.txtPlainText.Text = strIncomingFile;
			}
		}

 		private void mnuOpenCipherText_Click(object sender, System.EventArgs e)
		{
			string strIncomingFile = "";
			this.txtPlainText.Text = "";
			this.txtCipherText.Text = "";
			this.lblKey_DP.Text = "";
			this.lblKey_SAD.Text = "";
			this.lblKey_SS.Text = "";
			this.lblKeyLength_DP.Text = "";
			this.lblKeyLength_SAD.Text = "";
			this.lblKeyLength_SS.Text = "";

			if(openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				System.IO.StreamReader sr = new 
					System.IO.StreamReader(openFileDialog1.FileName);
				strIncomingFile = sr.ReadToEnd();
				sr.Close();
				strIncomingFile = strIncomingFile.Replace(" ","");
				strIncomingFile = strIncomingFile.Replace('\u000D'.ToString(),"");
				strIncomingFile = strIncomingFile.Replace('\u000A'.ToString(),"");
				strIncomingFile = strIncomingFile.ToLower();
				this.txtCipherText.Text = strIncomingFile;
			}
		}

		private void btnDecrypt_DP_Click(object sender, System.EventArgs e)
		{
			if(this.lblKey_DP.Text == "")
			{
				MessageBox.Show("You must analyze ciphertext before attempting this command.","Please Perform Analysis");
			}
			else
			{
				this.txtPlainText.Text = "";
				char[] chrArrayCipherText = this.txtCipherText.Text.ToString().ToCharArray();
				char[] chrArrayKey = this.lblKey_DP.Text.ToString().ToCharArray();
				int intPlainLetterIndex = 0;
				for (int i=0;i<this.txtCipherText.TextLength;)
				{
					for (int j=0;j<this.lblKey_DP.Text.Length;j++)
					{
						if ((i + j)<this.txtCipherText.TextLength)
						{
							intPlainLetterIndex = GetEnglishLetterIndex(chrArrayCipherText[i+j]) - GetEnglishLetterIndex(chrArrayKey[j]);
							if (intPlainLetterIndex < 0)
							{
								intPlainLetterIndex = 26 + intPlainLetterIndex;
							}
							this.txtPlainText.Text = this.txtPlainText.Text.ToString() + GetEnglishLetter(intPlainLetterIndex).ToString();
						}
					}
					i = i + this.lblKey_DP.Text.Length;
				}
			}
		}

		private void btnDecrypt_SAD_Click(object sender, System.EventArgs e)
		{
			if(this.lblKey_SAD.Text == "")
			{
				MessageBox.Show("You must analyze ciphertext before attempting this command.","Please Perform Analysis");
			}
			else
			{
				this.txtPlainText.Text = "";
				char[] chrArrayCipherText = this.txtCipherText.Text.ToString().ToCharArray();
				char[] chrArrayKey = this.lblKey_SAD.Text.ToString().ToCharArray();
				int intPlainLetterIndex = 0;
				for (int i=0;i<this.txtCipherText.TextLength;)
				{
					for (int j=0;j<this.lblKey_SAD.Text.Length;j++)
					{
						if ((i + j)<this.txtCipherText.TextLength)
						{
							intPlainLetterIndex = GetEnglishLetterIndex(chrArrayCipherText[i+j]) - GetEnglishLetterIndex(chrArrayKey[j]);
							if (intPlainLetterIndex < 0)
							{
								intPlainLetterIndex = 26 + intPlainLetterIndex;
							}
							this.txtPlainText.Text = this.txtPlainText.Text.ToString() + GetEnglishLetter(intPlainLetterIndex).ToString();
						}
					}
					i = i + this.lblKey_SAD.Text.Length;
				}
			}
		}

		private void btnDecrypt_SS_Click(object sender, System.EventArgs e)
		{
			if(this.lblKey_SS.Text == "")
			{
				MessageBox.Show("You must analyze ciphertext before attempting this command.","Please Perform Analysis");
			}
			else
			{
				this.txtPlainText.Text = "";
				char[] chrArrayCipherText = this.txtCipherText.Text.ToString().ToCharArray();
				char[] chrArrayKey = this.lblKey_SS.Text.ToString().ToCharArray();
				int intPlainLetterIndex = 0;
				for (int i=0;i<this.txtCipherText.TextLength;)
				{
					for (int j=0;j<this.lblKey_SS.Text.Length;j++)
					{
						if ((i + j)<this.txtCipherText.TextLength)
						{
							intPlainLetterIndex = GetEnglishLetterIndex(chrArrayCipherText[i+j]) - GetEnglishLetterIndex(chrArrayKey[j]);
							if (intPlainLetterIndex < 0)
							{
								intPlainLetterIndex = 26 + intPlainLetterIndex;
							}
							this.txtPlainText.Text = this.txtPlainText.Text.ToString() + GetEnglishLetter(intPlainLetterIndex).ToString();
						}
					}
					i = i + this.lblKey_SS.Text.Length;
				}
			}
		}

		private void btnDecrypt_Click(object sender, System.EventArgs e)
		{
			if(this.txtKey_Decrypt.Text == "")
			{
				MessageBox.Show("Please enter a key before attempting to decrypt ciphertext.","Please Enter Key");
			}
			else			
			{
				this.txtPlainText.Text = "";
				char[] chrArrayCipherText = this.txtCipherText.Text.ToString().ToCharArray();
				char[] chrArrayKey = this.txtKey_Decrypt.Text.ToString().ToCharArray();
				int intPlainLetterIndex = 0;
				for (int i=0;i<this.txtCipherText.TextLength;)
				{
					for (int j=0;j<this.txtKey_Decrypt.Text.Length;j++)
					{
						if ((i + j)<this.txtCipherText.TextLength)
						{
							intPlainLetterIndex = GetEnglishLetterIndex(chrArrayCipherText[i+j]) - GetEnglishLetterIndex(chrArrayKey[j]);
							if (intPlainLetterIndex < 0)
							{
								intPlainLetterIndex = 26 + intPlainLetterIndex;
							}
							this.txtPlainText.Text = this.txtPlainText.Text.ToString() + GetEnglishLetter(intPlainLetterIndex).ToString();
						}
					}
					i = i + this.txtKey_Decrypt.Text.Length;
				}
			}
		}

		private void btnEncrypt_Click(object sender, System.EventArgs e)
		{
			if(this.txtKey_Encrypt.Text == "" || this.txtPlainText.Text == "") 
			{
				if(this.txtPlainText.Text == "") 
				{
					MessageBox.Show("Please enter a message for encryption.","Enter Plain Text");
				}
				else
				{
					MessageBox.Show("It would be wise to use a key before trying to encrypt a message :-)","Please Enter Key");
				}
			}
			else			
			{
				string strCipherText = "";
				string strEncryptedFileText = "";
				int intCipherLetterIndex = 0;
				char[] chrArrayPlainText = this.txtPlainText.Text.ToString().ToCharArray();
				char[] chrArrayKey = this.txtKey_Encrypt.Text.ToString().ToCharArray();

				for (int i=0;i<this.txtPlainText.TextLength;)
				{
					for (int j=0;j<this.txtKey_Encrypt.Text.Length;j++)
					{
						if ((i + j)<this.txtPlainText.TextLength)
						{
							intCipherLetterIndex = GetEnglishLetterIndex(chrArrayPlainText[i+j]) + GetEnglishLetterIndex(chrArrayKey[j]);
							if (intCipherLetterIndex > 25)
							{
								intCipherLetterIndex = intCipherLetterIndex - 26;
							}
							strCipherText = strCipherText+ GetEnglishLetter(intCipherLetterIndex).ToString();
						}
					}
					i = i + this.txtKey_Encrypt.Text.Length;
				}
				
				strCipherText = strCipherText.ToUpper();
				char[] chrArrayCipherText = strCipherText.ToCharArray();
				strEncryptedFileText = "";
				for (int i =0;i<strCipherText.Length;)
				{
					for (int j=0;j<5;j++)
					{
						if((i+j)<strCipherText.Length)
						{
							strEncryptedFileText = strEncryptedFileText + chrArrayCipherText[i+j].ToString();
						}
					}
					strEncryptedFileText = strEncryptedFileText + " ";
					i = i + 5;
				}
				FileStream fsEncryptedText = null;
				BinaryWriter bwFileOut = null;
				this.saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*" ;
				saveFileDialog1.FilterIndex = 1;
				saveFileDialog1.RestoreDirectory = true ;
				if( this.saveFileDialog1.ShowDialog() == DialogResult.OK )
				{
					fsEncryptedText = new FileStream(this.saveFileDialog1.FileName, FileMode.Create);
					bwFileOut = new BinaryWriter(fsEncryptedText);
					bwFileOut.Flush();
					bwFileOut.Write(strEncryptedFileText.ToString().ToCharArray());
					bwFileOut.Close();
					fsEncryptedText.Close();
				}
			}
		}
	}
}

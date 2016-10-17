using CommonTypesLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientFormApplication {
	public partial class Form1 : Form {

		ClientInterface _client = null;


		public Form1() {
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e) {


		}

		private void textBox3_TextChanged(object sender, EventArgs e) {

		}

		private void Register_Click(object sender, EventArgs e) {
			string username = textBox1.Text;
			string port = textBox2.Text;

			_client = new Client(username, port);
		}

		private void button2_Click(object sender, EventArgs e) {
			_client.sendMessage(textBox4.Text);
		}

		private void label1_Click(object sender, EventArgs e) {

		}
	}
}

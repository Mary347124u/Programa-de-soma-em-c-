/*
 * Created by SharpDevelop.
 * User: DELL
 * Date: 26/02/2021
 * Time: 10:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace programaDeSoma
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void TextBox1TextChanged(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			Close();
		}
		void Button2Click(object sender, EventArgs e)
		{
			int num1,num2,resultado;
			num1 = Convert.ToInt16(textBox1.Text);
			num2 = Convert.ToInt16(textBox2.Text);
			resultado = num1+num2;
			label4.Text= Convert.ToString(resultado);
		}
	}
}

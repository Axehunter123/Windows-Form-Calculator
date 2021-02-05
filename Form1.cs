using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Calculator{
    public partial class Form1 : Form{
        public Form1(){
            InitializeComponent();}
        private void Form1_Load(object sender, EventArgs e){}
        private void button17_Click(object sender, EventArgs e){
            if(textBox2.Text == ""){
                return;}
            if (textBox2.Text.Substring(textBox2.Text.Length - 1) == " "){
                textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 3);}
            else{
                textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 1);}}
        private void textBox2_TextChanged(object sender, EventArgs e){}
        //Point a
        private void button9_Click(object sender, EventArgs e){
            textBox2.Text += "1";}
        private void button10_Click(object sender, EventArgs e){
            textBox2.Text += "2";}
        private void button11_Click(object sender, EventArgs e){
            textBox2.Text += "3";}
        private void button5_Click(object sender, EventArgs e){
            textBox2.Text += "4";}
        private void button6_Click(object sender, EventArgs e){
            textBox2.Text += "5";}
        private void button7_Click(object sender, EventArgs e){
            textBox2.Text += "6";}
        private void button1_Click(object sender, EventArgs e){
            textBox2.Text += "7";}
        private void button2_Click(object sender, EventArgs e){
            textBox2.Text += "8";}
        private void button3_Click(object sender, EventArgs e){
            textBox2.Text += "9";}
        private void button15_Click(object sender, EventArgs e){
            textBox2.Text += "0";}
        private void button13_Click(object sender, EventArgs e){
            if (textBox2.Text.Substring(textBox2.Text.Length - 1, 1) != "."){
                textBox2.Text += ".";}
            else{
                MessageBox.Show("One footstop allowed.", "Syntax Error", MessageBoxButtons.OK, MessageBoxIcon.Error);}}
        private void button4_Click(object sender, EventArgs e){
            textBox2.Text += " + ";}
        private void button8_Click(object sender, EventArgs e){
            textBox2.Text += " - ";}
        private void button12_Click(object sender, EventArgs e){
            textBox2.Text += " * ";}
        private void button14_Click(object sender, EventArgs e){
            textBox2.Text += " / ";}
        private void button16_Click(object sender, EventArgs e) {
            char[] separators = new char[] { '+', '-', '*', '/' };
            string[] str = textBox2.Text.Split(' ');
            double answer = 0;
            //I made this part first because * and / are calculated first.
            for (int i = 0; i < str.Length; i++){
                if (str[i] == "*"){
                    if (i >= 1 && i % 2 == 1){
                        if (i - 1 != 0){
                            if (answer != 0) { answer += answer * Convert.ToDouble(str[i + 1]);}
                            else{
                                answer = Convert.ToDouble(str[i - 1]) * Convert.ToDouble(str[i + 1]);}}
                        else { answer += Convert.ToDouble(str[0]) * Convert.ToDouble(str[i + 1]); }}
                    else{
                        return;}}
                else if (str[i] == "/"){
                    if (i >= 1 && i % 2 == 1){
                        if (i - 1 != 0) {
                            if (answer != 0){
                                answer += answer / Convert.ToDouble(str[i + 1]);}
                            else{
                                answer = Convert.ToDouble(str[i - 1]) / Convert.ToDouble(str[i + 1]);}}
                        else { answer += Convert.ToDouble(str[0]) / Convert.ToDouble(str[i + 1]); }}
                    else{return;}}
            for (int i = 0;i < str.Length; i++){
                if(str[i] == "+" ){
                    if(i >= 1 && i % 2 == 1){
                        if(i - 1 != 0) { answer += Convert.ToDouble(str[i + 1]); }
                        else {
                            if (answer == 0){
                                answer += Convert.ToDouble(str[0]) + Convert.ToDouble(str[i + 1]);}
                            else{
                                answer += Convert.ToDouble(str[0]);}}}
                    else{
                        return;}}
                else if (str[i] == "-"){
                    if (i >= 1 && i % 2 == 1){
                        if (i - 1 != 0) { answer -= Convert.ToDouble(str[i + 1]); }
                        else {
                            if (answer == 0){
                                answer += Convert.ToDouble(str[0]) - Convert.ToDouble(str[i + 1]);}
                            else{
                                answer = Convert.ToDouble(str[0]) - answer;}}}
                    else{
                        return;}}}
            if(str.Length == 1){
                answer = Convert.ToDouble(str[0]);}
            MessageBox.Show(answer.ToString());
            textBox2.Text = "";}}}
//Create 17 Button, 1 Text Box.
//View Point a to see which button is corresponding to what number.
//Button 16 is Calculate.
//Button 17 is delete.
//This program uses a split blank space to separate numbers and symbols. Avoid to change number manually. If you need to enter negative number, please just enter a - directly in front of the number.

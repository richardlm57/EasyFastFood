using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Fibonacci : System.Web.UI.Page
{

    int[] fibonacciSec;

    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void ButtonFibonacci_Click(object sender, EventArgs e)
    {
        int n = int.Parse(TextBoxFibonacci.Text);
        fibonacciSec = new int[n+1];
        for (int i = 0; i < n + 1; i++) {
            fibonacciSec[i] = -1;
        }
        int resultado = fibonacci(n);
        LabelFibonacci.Text = "";
        for (int i = 0; i < fibonacciSec.Length; i++) {
            LabelFibonacci.Text += fibonacciSec[i].ToString() + " | ";
        }
    }
    
    protected int fibonacci(int n){
        if ((n == 0) || (n == 1))
        {
            fibonacciSec[n] = n;
            return n;
        }
        int n1,n2;
        if (fibonacciSec[n - 1] == -1)
        {
            n1 = fibonacciSec[n - 1];
        }
        else {
            n1 = fibonacci(n - 1);
        }
        if (fibonacciSec[n - 2] == -1)
        {
            n2 = fibonacciSec[n - 2];
        }
        else
        {
            n2 = fibonacci(n - 2);
        }
        fibonacciSec[n]=n1+n2;
        return n1+n2;
    }

}
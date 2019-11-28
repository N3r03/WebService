using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for CalculatorWebService
/// </summary>
[WebService(Namespace = "http://google.com/webservices")]
//[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[WebServiceBinding(ConformsTo = WsiProfiles.None)]
[System.ComponentModel.ToolboxItem(false)]
public class CalculatorWebService : System.Web.Services.WebService
{

    //[WebMethod(MessageName = "Add3Numbers")]
    //public int Add(int firstNumber, int secondNumber, int thirdNumber)
    //{
    //    return firstNumber + secondNumber + thirdNumber;
    //}

    [WebMethod(EnableSession = true, Description="Add two numbers", CacheDuration=20)]
    //[WebMethod(EnableSession = true)]
    //[WebMethod]
    public int Add(int firstNumber, int secondNumber)
    {

        List<string> calculations;

        if (Session["CALCULATIONS"] == null)
        {
            calculations = new List<string>();
        }
        else
        {
            calculations = (List<string>)Session["CALCULATIONS"];
        }

        string strTransaction = firstNumber.ToString() + " + "
            + secondNumber.ToString()
            + " = " + (firstNumber + secondNumber).ToString();
        calculations.Add(strTransaction);
        Session["CALCULATIONS"] = calculations;

        return firstNumber + secondNumber;
    }
    [WebMethod(EnableSession = true, Description = "Substract two numbers", CacheDuration = 20)]
    public int Substract(int firstNumber, int secondNumber)
    {
        List<string> calculations;

        if (Session["CALCULATIONS"] == null)
        {
            calculations = new List<string>();
        }
        else
        {
            calculations = (List<string>)Session["CALCULATIONS"];
        }

        string strTransaction = firstNumber.ToString() + " + "
            + secondNumber.ToString()
            + " = " + (firstNumber - secondNumber).ToString();
        calculations.Add(strTransaction);
        Session["CALCULATIONS"] = calculations;

        return firstNumber - secondNumber;
    }
    [WebMethod(EnableSession = true, Description = "Divide two numbers", CacheDuration = 20)]
    public int Divide(int firstNumber, int secondNumber)
    {
        List<string> calculations;

        if (Session["CALCULATIONS"] == null)
        {
            calculations = new List<string>();
        }
        else
        {
            calculations = (List<string>)Session["CALCULATIONS"];
        }

        string strTransaction = firstNumber.ToString() + " + "
            + secondNumber.ToString()
            + " = " + (firstNumber - secondNumber).ToString();
        calculations.Add(strTransaction);
        Session["CALCULATIONS"] = calculations;

        return firstNumber / secondNumber;
    }
    [WebMethod(EnableSession = true, Description = "Multiply two numbers", CacheDuration = 20)]
    public int Multiply(int firstNumber, int secondNumber)
    {
        List<string> calculations;

        if (Session["CALCULATIONS"] == null)
        {
            calculations = new List<string>();
        }
        else
        {
            calculations = (List<string>)Session["CALCULATIONS"];
        }

        string strTransaction = firstNumber.ToString() + " + "
            + secondNumber.ToString()
            + " = " + (firstNumber - secondNumber).ToString();
        calculations.Add(strTransaction);
        Session["CALCULATIONS"] = calculations;

        return firstNumber * secondNumber;
    }

    //[WebMethod(EnableSession = true)]
    //public List<string> GetCalculations()
    //{
    //    if (Session["CALCULATIONS"] == null)
    //    {
    //        List<string> calculations = new List<string>();
    //        calculations.Add("You have not performed any calculations");
    //        return calculations;
    //    }
    //    else
    //    {
    //        return (List<string>)Session["CALCULATIONS"];
    //    }
    //}

}

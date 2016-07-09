using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
	public string GetData(int value)
	{
		return string.Format("You entered: {0}", value);
	}

    public string Add(int value1,int value2)
    {
        return string.Format("Sum: {0}", value1+ value2);
    }

    public string Sub(int value1,int value2)
    {
        return string.Format("Difference:{0}",value1-value2);
    }

    public string Mult(int value1,int value2)
    {
        return string.Format("Multiplication: {0}", value1*value2);
    }

    public string Div(int value1,int value2)
    {
        return string.Format("Division: {0}", value1/value2);
    }

    public string Mod(int value1, int value2)
    {
        return string.Format("Division: {0}", value1 / value2);
    }

	public CompositeType GetDataUsingDataContract(CompositeType composite)
	{
		if (composite == null)
		{
			throw new ArgumentNullException("composite");
		}
		if (composite.BoolValue)
		{
			composite.StringValue += "Suffix";
		}
		return composite;
	}
}

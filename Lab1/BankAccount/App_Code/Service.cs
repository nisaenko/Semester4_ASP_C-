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

    public string Withdaw(int value1, int value2)
    {
        return string.Format("Withdraw: {0}", value1 - value2);
    }

    public string Deposit(int value1, int value2)
    {
        return string.Format("Deposit: {0}", value1 + value2);
    }

    public string Balance(int value)
    {
        return string.Format("Balance: {0}", value);
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

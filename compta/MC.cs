using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Globalization;
using DevExpress.Spreadsheet.Functions;

namespace compta;

public class MC : ICustomFunction, IFunction
{
	private const string functionName = "MC";

	private readonly ParameterInfo[] functionParameters;

	public string Name => "MC";

	ParameterInfo[] IFunction.Parameters => functionParameters;

	ParameterType IFunction.ReturnType => ParameterType.Value;

	bool IFunction.Volatile => true;

	public MC()
	{
		functionParameters = new ParameterInfo[1]
		{
			new ParameterInfo(ParameterType.Value, ParameterAttributes.Required)
		};
	}

	ParameterValue IFunction.Evaluate(IList<ParameterValue> parameters, EvaluationContext context)
	{
		string cpt = parameters[0].ToString();
		OleDbCommand oleDbCommand = new OleDbCommand("SELECT SUM(CRE)  FROM Ecritures WHERE (JA<>'00') AND (UNI='" + monModule.gUNI + "') AND (EXERCICE=" + monModule.gExercice + ") AND (CPT LIKE '" + cpt + "%')", monModule.gbase);
		object o = oleDbCommand.ExecuteScalar();
		oleDbCommand.Dispose();
		return (o == DBNull.Value) ? 0m : Convert.ToDecimal(o);
	}

	string IFunction.GetName(CultureInfo culture)
	{
		return "MC";
	}
}

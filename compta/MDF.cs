using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Globalization;
using DevExpress.Spreadsheet.Functions;

namespace compta;

public class MDF : ICustomFunction, IFunction
{
	private const string functionName = "MDF";

	private readonly ParameterInfo[] functionParameters;

	public string Name => "MDF";

	ParameterInfo[] IFunction.Parameters => functionParameters;

	ParameterType IFunction.ReturnType => ParameterType.Value;

	bool IFunction.Volatile => true;

	public MDF()
	{
		functionParameters = new ParameterInfo[1]
		{
			new ParameterInfo(ParameterType.Value, ParameterAttributes.Required)
		};
	}

	ParameterValue IFunction.Evaluate(IList<ParameterValue> parameters, EvaluationContext context)
	{
		string cpt = parameters[0].ToString();
		OleDbCommand oleDbCommand = new OleDbCommand("SELECT SUM(DEB)  FROM Ecritures WHERE (JA<>'00') AND (UNI='" + monModule.gUNI + "') AND (EXERCICE=" + monModule.gExercice + ") AND (CPT LIKE '" + cpt + "%')", monModule.gbase);
		object o = oleDbCommand.ExecuteScalar();
		oleDbCommand.Dispose();
		return (o == DBNull.Value) ? 0m : Math.Round(Convert.ToDecimal(o), 0, MidpointRounding.AwayFromZero);
	}

	string IFunction.GetName(CultureInfo culture)
	{
		return "MDF";
	}
}

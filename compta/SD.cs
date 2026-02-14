using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Globalization;
using DevExpress.Spreadsheet.Functions;

namespace compta;

public class SD : ICustomFunction, IFunction
{
	private const string functionName = "SD";

	private readonly ParameterInfo[] functionParameters;

	public string Name => "SD";

	ParameterInfo[] IFunction.Parameters => functionParameters;

	ParameterType IFunction.ReturnType => ParameterType.Value;

	bool IFunction.Volatile => true;

	public SD()
	{
		functionParameters = new ParameterInfo[1]
		{
			new ParameterInfo(ParameterType.Value, ParameterAttributes.Required)
		};
	}

	ParameterValue IFunction.Evaluate(IList<ParameterValue> parameters, EvaluationContext context)
	{
		string cpt = parameters[0].ToString();
		object o = null;
		OleDbCommand oleDbCommand = new OleDbCommand($"SELECT SUM(DEB) FROM Balance   WHERE (EXERCICE={monModule.gExercice}) AND  CPT LIKE '{cpt}%'", monModule.gbase);
		o = oleDbCommand.ExecuteScalar();
		oleDbCommand.Dispose();
		decimal value = ((o == DBNull.Value) ? 0m : Convert.ToDecimal(o));
		Console.WriteLine(Math.Abs(value).ToString());
		return Math.Abs(value);
	}

	string IFunction.GetName(CultureInfo culture)
	{
		return "SD";
	}
}

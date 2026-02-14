using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Globalization;
using DevExpress.Spreadsheet.Functions;

namespace compta;

public class SCP : ICustomFunction, IFunction
{
	private const string functionName = "SCP";

	private readonly ParameterInfo[] functionParameters;

	public string Name => "SCP";

	ParameterInfo[] IFunction.Parameters => functionParameters;

	ParameterType IFunction.ReturnType => ParameterType.Value;

	bool IFunction.Volatile => true;

	public SCP()
	{
		functionParameters = new ParameterInfo[1]
		{
			new ParameterInfo(ParameterType.Value, ParameterAttributes.Required)
		};
	}

	ParameterValue IFunction.Evaluate(IList<ParameterValue> parameters, EvaluationContext context)
	{
		string cpt = parameters[0].ToString();
		OleDbCommand oleDbCommand = new OleDbCommand($"SELECT SUM(CRE) FROM Balance   WHERE (EXERCICE={monModule.gExercice - 1}) AND  CPT LIKE '{cpt}%'", monModule.gbase);
		object o = oleDbCommand.ExecuteScalar();
		oleDbCommand.Dispose();
		return Math.Abs((o == DBNull.Value) ? 0m : Convert.ToDecimal(o));
	}

	string IFunction.GetName(CultureInfo culture)
	{
		return "SCP";
	}
}

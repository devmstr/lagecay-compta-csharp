using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Globalization;
using DevExpress.Spreadsheet.Functions;

namespace compta;

public class SDPF : ICustomFunction, IFunction
{
	private const string functionName = "SDPF";

	private readonly ParameterInfo[] functionParameters;

	public string Name => "SDPF";

	ParameterInfo[] IFunction.Parameters => functionParameters;

	ParameterType IFunction.ReturnType => ParameterType.Value;

	bool IFunction.Volatile => true;

	public SDPF()
	{
		functionParameters = new ParameterInfo[1]
		{
			new ParameterInfo(ParameterType.Value, ParameterAttributes.Required)
		};
	}

	ParameterValue IFunction.Evaluate(IList<ParameterValue> parameters, EvaluationContext context)
	{
		string cpt = parameters[0].ToString();
		OleDbCommand oleDbCommand = new OleDbCommand($"SELECT SUM(DEB) FROM Balance   WHERE (EXERCICE={monModule.gExercice - 1}) AND  CPT LIKE '{cpt}%'", monModule.gbase);
		object o = oleDbCommand.ExecuteScalar();
		oleDbCommand.Dispose();
		return Math.Round(Math.Abs((o == DBNull.Value) ? 0m : Convert.ToDecimal(o)), 0, MidpointRounding.AwayFromZero);
	}

	string IFunction.GetName(CultureInfo culture)
	{
		return "SDPF";
	}
}

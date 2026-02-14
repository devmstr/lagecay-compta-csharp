using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Globalization;
using DevExpress.Spreadsheet.Functions;

namespace compta;

public class Inspection : ICustomFunction, IFunction
{
	private const string functionName = "Inspection";

	private readonly ParameterInfo[] functionParameters;

	public string Name => "Inspection";

	ParameterInfo[] IFunction.Parameters => functionParameters;

	ParameterType IFunction.ReturnType => ParameterType.Value;

	bool IFunction.Volatile => true;

	public Inspection()
	{
		functionParameters = new ParameterInfo[0];
	}

	ParameterValue IFunction.Evaluate(IList<ParameterValue> parameters, EvaluationContext context)
	{
		OleDbCommand oleDbCommand = new OleDbCommand("SELECT Inspection  FROM Dossiers   WHERE  UNI='" + monModule.gUNI + "'", monModule.gbase);
		object o = oleDbCommand.ExecuteScalar();
		oleDbCommand.Dispose();
		return (o == DBNull.Value) ? "" : o.ToString();
	}

	string IFunction.GetName(CultureInfo culture)
	{
		return "Inspection";
	}
}

using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Globalization;
using DevExpress.Spreadsheet.Functions;

namespace compta;

public class ACTAR : ICustomFunction, IFunction
{
	private const string functionName = "ACTAR";

	private readonly ParameterInfo[] functionParameters;

	public string Name => "ACTAR";

	ParameterInfo[] IFunction.Parameters => functionParameters;

	ParameterType IFunction.ReturnType => ParameterType.Value;

	bool IFunction.Volatile => true;

	public ACTAR()
	{
		functionParameters = new ParameterInfo[0];
	}

	ParameterValue IFunction.Evaluate(IList<ParameterValue> parameters, EvaluationContext context)
	{
		OleDbCommand oleDbCommand = new OleDbCommand("SELECT ACTAR  FROM Dossiers  WHERE  UNI='" + monModule.gUNI + "'", monModule.gbase);
		object o = oleDbCommand.ExecuteScalar();
		oleDbCommand.Dispose();
		return (o == DBNull.Value) ? "" : o.ToString();
	}

	string IFunction.GetName(CultureInfo culture)
	{
		return "ACTAR";
	}
}

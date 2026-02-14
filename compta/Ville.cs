using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Globalization;
using DevExpress.Spreadsheet.Functions;

namespace compta;

public class Ville : ICustomFunction, IFunction
{
	private const string functionName = "Ville";

	private readonly ParameterInfo[] functionParameters;

	public string Name => "Ville";

	ParameterInfo[] IFunction.Parameters => functionParameters;

	ParameterType IFunction.ReturnType => ParameterType.Value;

	bool IFunction.Volatile => true;

	public Ville()
	{
		functionParameters = new ParameterInfo[0];
	}

	ParameterValue IFunction.Evaluate(IList<ParameterValue> parameters, EvaluationContext context)
	{
		OleDbCommand oleDbCommand = new OleDbCommand("SELECT Villes.LIB FROM Villes INNER JOIN Dossiers ON Villes.CP = Dossiers.CPWilaya  WHERE  UNI='" + monModule.gUNI + "'", monModule.gbase);
		object o = oleDbCommand.ExecuteScalar();
		oleDbCommand.Dispose();
		return (o == DBNull.Value) ? "" : o.ToString();
	}

	string IFunction.GetName(CultureInfo culture)
	{
		return "Ville";
	}
}

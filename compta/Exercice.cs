using System.Collections.Generic;
using System.Globalization;
using DevExpress.Spreadsheet.Functions;

namespace compta;

public class Exercice : ICustomFunction, IFunction
{
	private const string functionName = "Exercice";

	private readonly ParameterInfo[] functionParameters;

	public string Name => "Exercice";

	ParameterInfo[] IFunction.Parameters => functionParameters;

	ParameterType IFunction.ReturnType => ParameterType.Value;

	bool IFunction.Volatile => true;

	public Exercice()
	{
		functionParameters = new ParameterInfo[0];
	}

	ParameterValue IFunction.Evaluate(IList<ParameterValue> parameters, EvaluationContext context)
	{
		return monModule.gExercice;
	}

	string IFunction.GetName(CultureInfo culture)
	{
		return "Exercice";
	}
}

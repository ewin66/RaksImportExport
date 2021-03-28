using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Core;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using DevExpress.Xpo.DB.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JK.XAF.Module.Module.BusinessObjects
{
    [DefaultClassOptions]
    [NavigationItem("Administracyjne")]
    public class DocumentNumberGenerator : XPObject
    {
        public DocumentNumberGenerator(Session session) : base(session)
        { }

        [XafDisplayName("Typ obiektu")]
        [ValueConverter(typeof(TypeToStringConverter))]
        [ImmediatePostData]
        [TypeConverter(typeof(LocalizedClassInfoTypeConverter))]
        public Type DataType
        {
            get => GetPropertyValue<Type>(nameof(DataType));
            set => SetPropertyValue(nameof(DataType), value);
        }

        [ElementTypeProperty("DataType"), Size(SizeAttribute.Unlimited)]
        [EditorAlias(EditorAliases.PopupExpressionPropertyEditor)]

        public string SequenceExpression
        {
            get { return GetPropertyValue<string>(nameof(SequenceExpression)); }
            set { SetPropertyValue<string>(nameof(SequenceExpression), value); }
        }

        [ElementTypeProperty("DataType"), Size(SizeAttribute.Unlimited)]
        [EditorAlias(EditorAliases.PopupExpressionPropertyEditor)]

        public string NumberExpression
        {
            get { return GetPropertyValue<string>(nameof(NumberExpression)); }
            set { SetPropertyValue<string>(nameof(NumberExpression), value); }
        }


    }

    public static class DocumentNumberGeneratorHelper
    {
        public const int MaxIdGenerationAttemptsCounter = 7;



        public static void Generate(IDataLayer idGeneratorDataLayer, INumerowanieDok xpObject, string serverPrefix)
        {
            for (int attempt = 1; ; ++attempt)
            {
                try
                {
                    using (Session generatorSession = new Session(idGeneratorDataLayer))
                    {
                        SetNumber(xpObject, serverPrefix, generatorSession);
                        return;
                    }
                }
                catch (LockingException)
                {
                    if (attempt >= MaxIdGenerationAttemptsCounter)
                        throw;
                }
            }
        }




        private static void SetNumber(INumerowanieDok xpObject, string serverPrefix, Session generatorSession)
        {
            DocumentNumberGenerator generator = generatorSession.FindObject<DocumentNumberGenerator>(
                new BinaryOperator("DataType", xpObject.GetType()));
            if (generator == null)
            {
                generator = new DocumentNumberGenerator(generatorSession);
                generator.DataType = xpObject.GetType();
                //	generator.Prefix = serverPrefix;
            }
            if (!string.IsNullOrEmpty(generator.SequenceExpression) && !string.IsNullOrEmpty(generator.NumberExpression))
            {
                var expression = generator.SequenceExpression;

                var seq = xpObject.Evaluate(PrepareExpression(expression));
                if (seq != null)
                {

                    xpObject.NrKolejny = DistributedIdGeneratorHelper.Generate(generatorSession, xpObject.GetType().FullName, seq.ToString());

                    var nrExpression = generator.NumberExpression;
                    xpObject.Numer = xpObject.Evaluate(PrepareExpression(nrExpression)).ToString();

                }
            }

        }

        private static string PrepareExpression(string expression)
        {
            if (expression.Contains("!"))
                expression = expression.Replace("!", "");
            return expression;
        }

    }


    public interface INumerowanieDok
    {
        int NrKolejny { get; set; }
        string Numer { get; set; }
        object Evaluate(string expression);
    }
}

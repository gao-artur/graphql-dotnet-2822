using GraphQL.Types;
using GraphQL.Utilities;

namespace StarWars
{
    public class MyVisitor : BaseSchemaNodeVisitor
    {
        public override void VisitInterface(IInterfaceGraphType type, ISchema schema)
        {
            base.VisitInterface(type, schema);
        }

        public override void VisitInterfaceFieldArgumentDefinition(QueryArgument argument, FieldType field, IInterfaceGraphType type,
            ISchema schema)
        {
            base.VisitInterfaceFieldArgumentDefinition(argument, field, type, schema);
        }

        public override void VisitInterfaceFieldDefinition(FieldType field, IInterfaceGraphType type, ISchema schema)
        {
            base.VisitInterfaceFieldDefinition(field, type, schema);
        }

        public override void VisitInputObjectFieldDefinition(FieldType field, IInputObjectGraphType type, ISchema schema)
        {
            base.VisitInputObjectFieldDefinition(field, type, schema);
        }
    }
}

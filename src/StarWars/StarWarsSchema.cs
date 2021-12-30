using GraphQL.Types;
using System;
using Microsoft.Extensions.DependencyInjection;

namespace StarWars
{
    public class StarWarsSchema : Schema
    {
        public StarWarsSchema(IServiceProvider provider)
            : base(provider)
        {
            Query = provider.GetRequiredService<StarWarsQuery>();
            Mutation = provider.GetRequiredService<StarWarsMutation>();
            RegisterVisitor(new MyVisitor());
        }
    }
}

using Dapper;
using System.Data;

namespace Bookify.Infrastucture.Data;

/// <summary>
/// Необходим для того, чтобы маппить DateOnly в Dapper, т.к. Dapper не поддерживает DateOnly из коробки 
/// </summary>
internal sealed class DateOnlyTypeHandler : SqlMapper.TypeHandler<DateOnly>
{
    public override DateOnly Parse(object value) => DateOnly.FromDateTime((DateTime)value);

    public override void SetValue(IDbDataParameter parameter, DateOnly value)
    {
        parameter.DbType = DbType.Date;
        parameter.Value = value;
    }
}
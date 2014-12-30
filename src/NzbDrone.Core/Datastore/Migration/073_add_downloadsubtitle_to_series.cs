using System;
using System.Collections.Generic;
using System.Data;
using FluentMigrator;
using NzbDrone.Common.Serializer;
using NzbDrone.Core.Datastore.Migration.Framework;

namespace NzbDrone.Core.Datastore.Migration
{
    [Migration(73)]
    public class add_downloadsubtitle_to_series : NzbDroneMigrationBase
    {
        protected override void MainDbUpgrade()
        {
            Alter.Table("Series").AddColumn("SubtitleMonitored").AsBoolean().Nullable();
        }
    }
}

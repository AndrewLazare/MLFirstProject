using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace MLTutorial
{

    /// <summary>
    /// clustering in ML works as such...the cluster with the shortest distance is tha cluster that belongs.
    /// </summary>
    class ClusterPrediction
    {
        [ColumnName("PredictedLabel")]
        public uint PredictedClusterId;

        [ColumnName("Score")]
        public float[] Distances;
    }
}

#if !NETSTANDARD13
/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the elastictranscoder-2012-09-25.normal.json service model.
 */

namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// Paginators for the ElasticTranscoder service
    ///</summary>
    public interface IElasticTranscoderPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListJobsByPipeline operation
        ///</summary>
        IListJobsByPipelinePaginator ListJobsByPipeline(ListJobsByPipelineRequest request);

        /// <summary>
        /// Paginator for ListJobsByStatus operation
        ///</summary>
        IListJobsByStatusPaginator ListJobsByStatus(ListJobsByStatusRequest request);

        /// <summary>
        /// Paginator for ListPipelines operation
        ///</summary>
        IListPipelinesPaginator ListPipelines(ListPipelinesRequest request);

        /// <summary>
        /// Paginator for ListPresets operation
        ///</summary>
        IListPresetsPaginator ListPresets(ListPresetsRequest request);
    }
}
#endif
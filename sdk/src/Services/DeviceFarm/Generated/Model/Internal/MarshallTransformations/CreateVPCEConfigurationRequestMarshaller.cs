/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DeviceFarm.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.DeviceFarm.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateVPCEConfiguration Request Marshaller
    /// </summary>       
    public class CreateVPCEConfigurationRequestMarshaller : IMarshaller<IRequest, CreateVPCEConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateVPCEConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateVPCEConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DeviceFarm");
            string target = "DeviceFarm_20150623.CreateVPCEConfiguration";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetServiceDnsName())
                {
                    context.Writer.WritePropertyName("serviceDnsName");
                    context.Writer.Write(publicRequest.ServiceDnsName);
                }

                if(publicRequest.IsSetVpceConfigurationDescription())
                {
                    context.Writer.WritePropertyName("vpceConfigurationDescription");
                    context.Writer.Write(publicRequest.VpceConfigurationDescription);
                }

                if(publicRequest.IsSetVpceConfigurationName())
                {
                    context.Writer.WritePropertyName("vpceConfigurationName");
                    context.Writer.Write(publicRequest.VpceConfigurationName);
                }

                if(publicRequest.IsSetVpceServiceName())
                {
                    context.Writer.WritePropertyName("vpceServiceName");
                    context.Writer.Write(publicRequest.VpceServiceName);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateVPCEConfigurationRequestMarshaller _instance = new CreateVPCEConfigurationRequestMarshaller();        

        internal static CreateVPCEConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateVPCEConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}
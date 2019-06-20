// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.BatchAI.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Specifies a setup task which can be used to customize the compute nodes
    /// of the cluster.
    /// </summary>
    public partial class SetupTask
    {
        /// <summary>
        /// Initializes a new instance of the SetupTask class.
        /// </summary>
        public SetupTask()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SetupTask class.
        /// </summary>
        /// <param name="commandLine">Command line.</param>
        /// <param name="stdOutErrPathPrefix">Output path prefix.</param>
        /// <param name="environmentVariables">Environment variables.</param>
        /// <param name="secrets">Secrets.</param>
        /// <param name="stdOutErrPathSuffix">Output path suffix.</param>
        public SetupTask(string commandLine, string stdOutErrPathPrefix, IList<EnvironmentVariable> environmentVariables = default(IList<EnvironmentVariable>), IList<EnvironmentVariableWithSecretValue> secrets = default(IList<EnvironmentVariableWithSecretValue>), string stdOutErrPathSuffix = default(string))
        {
            CommandLine = commandLine;
            EnvironmentVariables = environmentVariables;
            Secrets = secrets;
            StdOutErrPathPrefix = stdOutErrPathPrefix;
            StdOutErrPathSuffix = stdOutErrPathSuffix;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets command line.
        /// </summary>
        /// <remarks>
        /// The command line to be executed on each cluster's node after it
        /// being allocated or rebooted. The command is executed in a bash
        /// subshell as a root.
        /// </remarks>
        [JsonProperty(PropertyName = "commandLine")]
        public string CommandLine { get; set; }

        /// <summary>
        /// Gets or sets environment variables.
        /// </summary>
        /// <remarks>
        /// A collection of user defined environment variables to be set for
        /// setup task.
        /// </remarks>
        [JsonProperty(PropertyName = "environmentVariables")]
        public IList<EnvironmentVariable> EnvironmentVariables { get; set; }

        /// <summary>
        /// Gets or sets secrets.
        /// </summary>
        /// <remarks>
        /// A collection of user defined environment variables with secret
        /// values to be set for the setup task. Server will never report
        /// values of these variables back.
        /// </remarks>
        [JsonProperty(PropertyName = "secrets")]
        public IList<EnvironmentVariableWithSecretValue> Secrets { get; set; }

        /// <summary>
        /// Gets or sets output path prefix.
        /// </summary>
        /// <remarks>
        /// The prefix of a path where the Batch AI service will upload the
        /// stdout, stderr and execution log of the setup task.
        /// </remarks>
        [JsonProperty(PropertyName = "stdOutErrPathPrefix")]
        public string StdOutErrPathPrefix { get; set; }

        /// <summary>
        /// Gets output path suffix.
        /// </summary>
        /// <remarks>
        /// A path segment appended by Batch AI to stdOutErrPathPrefix to form
        /// a path where stdout, stderr and execution log of the setup task
        /// will be uploaded. Batch AI creates the setup task output
        /// directories under an unique path to avoid conflicts between
        /// different clusters. The full path can be obtained by concatenation
        /// of stdOutErrPathPrefix and stdOutErrPathSuffix.
        /// </remarks>
        [JsonProperty(PropertyName = "stdOutErrPathSuffix")]
        public string StdOutErrPathSuffix { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (CommandLine == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CommandLine");
            }
            if (StdOutErrPathPrefix == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "StdOutErrPathPrefix");
            }
            if (EnvironmentVariables != null)
            {
                foreach (var element in EnvironmentVariables)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (Secrets != null)
            {
                foreach (var element1 in Secrets)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
        }
    }
}
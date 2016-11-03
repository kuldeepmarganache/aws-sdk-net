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
 * Do not modify this file. This file is generated from the budgets-2016-10-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Budgets.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateBudget operation.
    /// Update the information of a budget already created
    /// </summary>
    public partial class UpdateBudgetRequest : AmazonBudgetsRequest
    {
        private string _accountId;
        private Budget _newBudget;

        /// <summary>
        /// Gets and sets the property AccountId.
        /// </summary>
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property NewBudget.
        /// </summary>
        public Budget NewBudget
        {
            get { return this._newBudget; }
            set { this._newBudget = value; }
        }

        // Check to see if NewBudget property is set
        internal bool IsSetNewBudget()
        {
            return this._newBudget != null;
        }

    }
}
// Copyright 2025 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;

namespace Google.Android.AppBundle.Editor.Internal.AssetPacks
{
    /// <summary>
    /// Tools for adding device group targeting to folders of an Android App Bundle.
    /// </summary>
    public static class DeviceGroupTargetingTools
    {
        /// <summary>
        /// The key used by bundletool to recognize a folder targeted for a specific device group,
        /// for example "group" in "assets#group_X".
        /// </summary>
        private const string DeviceGroupTargetingKey = "group";


        /// <summary>
        /// Get the targeting suffix for a given device group, to
        /// be appended to a folder name containing containing AssetBundles or raw files to be targeted.
        /// </summary>
        public static string GetTargetingSuffix(string group)
        {
            return string.Format("#{0}_{1}", DeviceGroupTargetingKey, group);
        }
    }
}
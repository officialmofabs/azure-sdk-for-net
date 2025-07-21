import { IAutorestLogger } from "@autorest/common";
import { AutorestConfiguration } from "@autorest/configuration";
import { Extension, ExtensionManager } from "@azure-tools/extension";
export declare const rootFolder: string;
export declare const extensionManager: Promise<ExtensionManager>;
export declare const oldCorePackage = "@microsoft.azure/autorest-core";
export declare const newCorePackage = "@autorest/core";
export declare const networkEnabled: Promise<boolean>;
export declare function availableVersions(): Promise<string[]>;
export declare function installedCores(): Promise<Extension[]>;
export declare function resolveEntrypoint(localPath: string, entrypoint: string): Promise<string | undefined>;
export declare function runCoreOutOfProc(localPath: string, entrypoint: string, config?: AutorestConfiguration): Promise<any>;
export declare function runCoreWithRequire(localPath: string, entrypoint: string, config?: AutorestConfiguration): Promise<any>;
export declare function ensureAutorestHome(): Promise<void>;
export declare function selectVersion(logger: IAutorestLogger, requestedVersion: string, force: boolean, minimumVersion?: string): Promise<Extension>;
//# sourceMappingURL=autorest-as-a-service.d.ts.map
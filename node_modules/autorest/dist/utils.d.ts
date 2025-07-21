import { IAutorestLogger, LoggerSink } from "@autorest/common";
import { AutorestConfiguration, AutorestNormalizedConfiguration } from "@autorest/configuration";
import { AutorestArgs } from "./args";
/**
 * Return the version requested of the core extension.
 * @param args ClI args.
 * @returns npm version/tag.
 */
export declare const getRequestedCoreVersion: (args: AutorestArgs) => string | undefined;
/**
 * Tries to load the configuration of autorest.
 * @param args CLI args.
 */
export declare function loadConfig(sink: LoggerSink, args: AutorestArgs): Promise<AutorestConfiguration | undefined>;
/**
 * Check if the requested version points to a local dev version of @autorest/core or there is one globally available.
 * @param requestedVersion Core version
 * @returns Path to the local version or undefined if there isn't one.
 */
export declare function resolvePathForLocalVersion(requestedVersion: string | null): Promise<string | undefined>;
export declare function resolveCoreVersion(logger: IAutorestLogger, config?: AutorestNormalizedConfiguration): Promise<string>;
/**
 *
 * @param maxMemory Max memory string(2048m, 2g)
 * @returns Max memory that will be allowed for the cnode process in MB
 */
export declare function parseMemory(maxMemory: string): number;
//# sourceMappingURL=utils.d.ts.map
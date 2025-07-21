/// <reference path="../definitions/core.d.ts" />
/// <reference path="../definitions/vscode.d.ts" />
import { IAutorestLogger } from "@autorest/common";
import { IFileSystem, AutoRest as IAutoRest } from "autorest-core";
export { Message, Artifact, GenerationResults, IFileSystem } from "autorest-core";
export { color } from "@autorest/common";
/**
 * The Channel that a message is registered with.
 */
export declare enum Channel {
    /** Information is considered the mildest of responses; not necesarily actionable. */
    Information,
    /** Warnings are considered important for best practices, but not catastrophic in nature. */
    Warning,
    /** Errors are considered blocking issues that block a successful operation.  */
    Error,
    /** Debug messages are designed for the developer to communicate internal autorest implementation details. */
    Debug,
    /** Verbose messages give the user additional clarity on the process. */
    Verbose,
    /** Catastrophic failure, likely abending the process.  */
    Fatal,
    /** Hint messages offer guidance or support without forcing action. */
    Hint,
    /** File represents a file output from an extension. Details are a Artifact and are required.  */
    File,
    /** content represents an update/creation of a configuration file. The final uri will be in the same folder as the primary config file. */
    Configuration,
    /** Protect is a path to not remove during a clear-output-folder.  */
    Protect
}
export declare enum DocumentType {
    OpenAPI2,
    OpenAPI3,
    LiterateConfiguration,
    Unknown
}
export declare type AutoRest = IAutoRest;
export declare const AutoRest: Promise<IAutoRest>;
/**
 * Returns the command-line application entrypoint for autorest-core, bootstrapping the core if necessary
 *
 * If initialize has already been called, then it returns the version that was initialized, regardless of parameters
 *
 * @param requestedVersion an npm package reference for the version requested @see {@link https://docs.npmjs.com/cli/install#description}
 *
 * @param minimumVersion - a semver string representing the lowest autorest-core version that is considered acceptable.
 *
 * @see {@link initialize}
 * */
export declare function getApplicationEntrypoint(logger: IAutorestLogger, requestedVersion?: string, minimumVersion?: string): Promise<string | undefined>;
/**
 * Initializes the AutoRest-core module, bootstrapping the core from npm if required.
 *
 * @param requestedVersion an npm package reference for the version requested @see {@link https://docs.npmjs.com/cli/install#description}
 *
 * a) a folder containing a program described by a package.json file
 * b) a gzipped tarball containing (a)
 * c) a url that resolves to (b)
 * d) a <name>@<version> that is published on the registry {@link https://docs.npmjs.com/misc/registry}) with (c)
 * e) a <name>@<tag> (see npm-dist-tag) that points to (d)
 * f) a <name> that has a "latest" tag satisfying (e)
 * g) a <git remote url> that resolves to (a)
 *
 * @param minimumVersion - a semver string representing the lowest autorest-core version that is considered acceptable.
 */
export declare function initialize(logger: IAutorestLogger, requestedVersion?: string, minimumVersion?: string): Promise<void>;
/**
 * Creates an instance of the AutoRest engine. Will call {@link initialize} with default values to bootstrap AutoRest core if necessary.
 *
 * @param fileSystem - the {@link IFileSystem} implementation that will be used to acquire files
 *
 * Note: http:/https:/mem: schemes are handled internally in AutoRest and the IFilesystem will not call
 * the IFileSystem methods.
 *
 *
 * @param configFileOrFolderUri - a URI pointing to the folder or autorest configuration file
 */
export declare function create(logger: IAutorestLogger, fileSystem?: IFileSystem, configFileOrFolderUri?: string): Promise<AutoRest>;
/**
 *  Given a document's content, does this represent a openapi document of some sort?
 *
 * @param content - the document content to evaluate
 */
export declare function isOpenApiDocument(logger: IAutorestLogger, content: string): Promise<boolean>;
/** Determines the document type based on the content of the document
 *
 * @returns Promise<DocumentType> one of:
 *  -  DocumentType.LiterateConfiguration - contains the magic string '\n> see https://aka.ms/autorest'
 *  -  DocumentType.OpenAPI2 - $.swagger === "2.0"
 *  -  DocumentType.OpenAPI3 - $.openapi === "3.0.0"
 *  -  DocumentType.Unknown - content does not match a known document type
 *
 * @see {@link DocumentType}
 */
export declare function identifyDocument(logger: IAutorestLogger, content: string): Promise<DocumentType>;
/**
 * Processes a document (yaml, markdown or JSON) and returns the document as a JSON-encoded document text
 * @param content - the document content
 *
 * @returns the content as a JSON string (not a JSON DOM)
 */
export declare function toJSON(logger: IAutorestLogger, content: string): Promise<string>;
//# sourceMappingURL=exports.d.ts.map
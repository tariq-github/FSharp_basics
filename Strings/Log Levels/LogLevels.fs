module LogLevels = 

    let message (logLine: string): string = 
        let splitLogLine = logLine.Split ':'
        let getMessage = splitLogLine[1].Trim()
        getMessage

    let logLevel(logLine: string): string = 
        let splitLogLine = logLine.Split ':'
        let logLevelMessage = splitLogLine[0]
        let logLevelMessageLength = logLevelMessage.Length 
        let getLogLevel = logLevelMessage[1..logLevelMessageLength-2].ToLower()
        getLogLevel

    let reformat(logLine: string): string = 
        let getMessage = message logLine
        let getLogLevel = logLevel logLine
        let finalString  = getMessage + " (" + getLogLevel + ")"
        finalString


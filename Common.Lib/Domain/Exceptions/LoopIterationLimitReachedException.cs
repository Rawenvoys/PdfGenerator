namespace PdfGenerator.Common.Lib.Domain.Exceptions;
public class LoopIterationLimitReachedException(int iterationLimit) : Exception($"Number of iteration inside loop reached the limit: {iterationLimit}") { }

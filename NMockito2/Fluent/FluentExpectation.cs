using System;
using NMockito2.Expectations;

namespace NMockito2.Fluent {
   public class FluentExpectation<T> {
      private readonly Expectation<T> expectation;

      public FluentExpectation(Expectation<T> expectation) {
         this.expectation = expectation;
      }

      public FluentExpectation<T> ThenReturns(params T[] value) {
         expectation.ThenReturn(value);
         return this;
      }

      public FluentExpectation<T> ThenThrows(params Exception[] e) {
         expectation.ThenThrow(e);
         return this;
      }
   }
}
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace LOS.Adapter.Data.Services.Extensions
{
    /// <summary>
    /// Extension Method for Task Library
    /// </summary>
    public static class TaskExtension
    {
        /// <summary>
        /// Timeouts the after.
        /// </summary>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="task">The task.</param>
        /// <param name="timeout">The timeout.</param>
        /// <returns></returns>
        /// <exception cref="System.TimeoutException">The operation has timed out.</exception>
        public static async Task<TResult> TimeoutAfter<TResult>(this Task<TResult> task, TimeSpan timeout)
        {

            var timeoutCancellationTokenSource = new CancellationTokenSource();

            var completedTask = await Task.WhenAny(task, Task.Delay(timeout, timeoutCancellationTokenSource.Token));
            if (completedTask == task)
            {
                timeoutCancellationTokenSource.Cancel();
                return await task;
            }
            else
            {
                throw new TimeoutException("The operation has timed out.");
            }
        }


        /// <summary>
        /// Runs the tak as asynchronous.
        /// </summary>
        /// <param name="this">The this.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentNullException"></exception>
        public static Task<object> RunAsync(this IEnumerator<Task> @this)
        {
            if (@this == null)
                throw new ArgumentNullException();

            var tcs = new TaskCompletionSource<object>();

            Action<Task> nextStep = null;
            nextStep = (previousTask) =>
            {
                try
                {
                    if (previousTask.IsCanceled)
                        tcs.SetCanceled();
                    else if (previousTask.IsFaulted)
                        tcs.SetException(previousTask.Exception);
                    else
                    {
                        // move to the next task
                        if (@this.MoveNext())
                        {
                            @this.Current.ContinueWith(nextStep,
                                TaskContinuationOptions.ExecuteSynchronously);
                        }
                        else
                            tcs.SetResult(previousTask);
                    }
                }
                catch (Exception ex)
                {
                    tcs.TrySetException(ex);
                }
            };

            nextStep(Task.FromResult(Type.Missing));

            return tcs.Task.ContinueWith(
                completedTask => { @this.Dispose(); return completedTask; },
                TaskContinuationOptions.ExecuteSynchronously).Unwrap();
        }
    }
}

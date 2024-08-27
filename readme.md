# Smart DotNet Test Job for Github Actions
This repo has an example GHA workflow that allows you to run dotnet tests and if it is rerun after a run with failed tests, it will only run the failed tests.
This is handy if you have flaky tests. You should fix the flaky tests but until then this helps.

## How it Works
* The job runs the full set of tests on the first run and outputs the results to an XML results file. This file is uploaded to the run artifacts.
* If the job is rerun, it attempts to download the artifact file from the previous run.
* If successful, the next step then installs libxml2-utils (for xmllint), strips out XML namespaces from the test results file (because xmllint doesn't like them) and then uses an XPath expression to get the list of failed tests
* If there are failed tests found then only those test are run, otherwise the default filter will be used and the usual set of tests are run
* Finally, the test results XML are uploaded to the run artifacts. The artifact name uses the run attempt number so that it doesn't overwrite the test results from any previous run attempt.

## Possible Enhancements
* One enhancement would be to automatically rerun the failed tests at least once. If the tests are genuinely flaky then this might help. However this might not be desirable in every situation, especially if the failure is legitimate.
* [Job summaries](https://docs.github.com/en/actions/writing-workflows/choosing-what-your-workflow-does/workflow-commands-for-github-actions#adding-a-job-summary)

## Bugs
* Not currently working with parametrised tests (will need to support inlinedata by escaping the `()` characters when processing the test name)
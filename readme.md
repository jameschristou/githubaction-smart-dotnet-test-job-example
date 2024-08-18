# Smart DotNet Test Job for Github Actions
This repo has an example workflow and job that allows you to rerun a job containing dotnet tests when some of those tests have failed.
It will only rerun the failed tests rather than the entire set of tests. This is handy if you have flaky tests. You should fix the flaky
tests but until then this helps.
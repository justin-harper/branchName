branchName

Console app to parse the output of
`git symbolic-ref -q HEAD`

For example: refs/origin/feature/ABCD-1234-Stuff&Things-And-Whatnot

This app will output ABCD-1234 to the console.

The purpose of this is to be run in the prepare-commit-msg git hook to make smart tagging in Jira work nicely.
I don't like having to type the Jira ticket number on each commit so this automates that pain.

Made with 💙 by Justin Harper
©️ 2021

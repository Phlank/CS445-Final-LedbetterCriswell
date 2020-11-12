# Student Showcase Demo

Colin Ledbetter and Zachary Criswell

# Development Environment Setup

## Windows 7, 8, and 10

1.  Clone the repository.

### Configure Web Dependencies

1.  Install Node.js and npm. Instructions for this can be found [here](https://www.npmjs.com/get-npm).
2.  Add the npm binary folder to your PATH. [Here](https://www.architectryan.com/2018/03/17/add-to-the-path-on-windows-10/) is a guide for adding directories to the PATH in Windows 10.
3.  Open Powershell and install [Yarn](https://yarnpkg.com/getting-started/install). The command to do this is `npm install -g yarn`.
4.  Navigate to the repository location within Powershell.
5.  Navigate to [root]/BSU.StudentShowcase and run the command `yarn install`. This will install all of the web dependencies used by the project.

### Configure IDE

1.  Install [Visual Studio Community 2019](https://visualstudio.microsoft.com/vs/community/).
2.  Once installed, run the software and open the solution found at [root]/BSU.StudentShowcase.sln
3.  Build and run the project by running the IIS Project configuration using the debug menu in the toolbar at the top of the IDE.

## Other Operating Systems

The scope of the project does not require this to be addressed at this time.

# Conventions

## Version Control & Branching

This project uses [Git](https://git-scm.com/) for version control.

For branching, this project uses a less intense version of Gitflow<sup>[[1]](https://nvie.com/posts/a-successful-git-branching-model/), [[2]](https://www.atlassian.com/git/tutorials/comparing-workflows/gitflow-workflow)</sup> with some changed branch names.

The branches used in this project are `main` in place of Gitflow's master, `development`, and `feature/*`.

No commits should be made directly to the main branch, and any commit contributing to a repository issue should be done within a feature branch named along the lines of `feature/gh-X_Brief_Issue_Description`, where X is the number of the issue on Github. In addition to this, commit message titles should begin with `gh-X: Brief description of work done`. This will link the commits directly to the issues and make work contributed to the issues much more clear.

Any finished feature branch should have a pull request made for it in this project and once reviewed, should be merged into the development branch through the Github web interface. Following this, the feature branch should be deleted on Github to keep the number of branches on remote low and limited to branches where active development is taking place.

## Style Conventions

This project follows [Microsoft's C# Coding Conventions](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions).

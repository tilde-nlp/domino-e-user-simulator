# DOMINO-E User Simulator
This repository contains a User Simulator developed for the **DOMINO-E** (https://domino-e.eu/) project.

In a typical setting, end users interact with DOMINO-E through a graphical user interface (UI) provided by the **User Access Service (UAS)**, which hosts or integrates the **Virtual Assistant Service (VAS)**. This interface is used by domain experts to test the system and provide feedback on various usage scenarios.

However, for end-to-end evaluations involving all three main components of DOMINO-E: **VAS**, **Coverage Service (CS)**, and **Satellite 
Communication and Resource Management System (SCRMS)** real-time testing is not practical. These scenarios can span several days or even weeks, making manual interaction infeasible.

To address this, we use a **time-simulated mode** with an automated user simulator. This simulator mimics real user interactions by:

- Receiving commands from the Dispatcher to start a simulation at a specific point in simulated time.
- Interacting with the UI as a human would — filling out forms, clicking buttons, waiting for responses, and executing predefined scenarios.

In essence, the **User Simulator** is an **automated UI testing script** that executes a specific user scenario and verifies whether the system behaves as expected. At the end of the simulation, it can optionally invoke a callback function to notify the Dispatcher that the simulated activity has been completed.

Each test run also generates a detailed report that includes:

- Whether the scenario execution was successful or failed,
- Execution time for each individual step,
- Total duration of the entire scenario.

This enables robust, repeatable, and measurable testing of complex DOMINO-E workflows.

The User Simulator is built on top of [Playwright](https://github.com/microsoft/playwright), a powerful framework for web testing and automation. Playwright enables cross-browser testing (Chromium, Firefox, and WebKit) through a single API. This project wraps Playwright in a containerized environment that includes the Playwright framework, test scripts, and APIs, allowing external systems — such as the DOMINO-E Dispatcher — to manage and trigger test execution.

# Content of the Repository
The repository is organized as follows:
- **DockerWright** is a set of tests for Playwright. All tests are under DockerWright/tests. See Playwright docs for how to write them. After any changes in the tests, rebuild DockerWright and make sure the image is available to DockerWrightManager

- **DockerWrightManager** 
 is a .NET web app that runs DockerWright images as jobs in Kubernetes and serves the test results.

## Relevant configuration keys - see appsettings.json for defaults and format

- KubernetesHost: Kubernetes API url.
- ImagePullSecret: Passed in the job spec.
- Image: DockerWright image name. Passed in the job spec.
- JobDefaultNamespace: Passed in the job spec.  
- JobDefaultRequestMemory: Passed in the job spec.
- JobDefaultRequestCPU: Passed in the job spec.

- ResultVolume: Passed to the job and also used by the Manager. This is where the test results are stored and served from.    
- URL: URL of this service. Used when generating links.
- PageURL: URL of the UI being tested, passed to the actual tests as PLAYWRIGHT_PAGE_URL env variable
  
- LogService: For error logging

## /api endpoints

### startjob 

Params:
- `callback` - string, optional

Runs the DockerWright image with "npm run test-html-report"
This runs every test in DockerWright/tests

If callback is specified, makes a HTTP GET request to callback when done.

### startone

Params:
- `test` - string
- `callback` - string, optional

Runs the DockerWright image with "npx playwright test {test} --browser=all --reporter=html"
This runs the specified test file (e.g. 'tests/test.spec.ts')
If callback is specified, makes a HTTP GET request to callback when done.
Returns job id.

### resultlist

Returns HTML with links to every test result currently stored in ResultVolume

### result

Parms:
- `path` - string

Serves one test result as HTML. Links to this are listed by resultlist

### complete

Params:
- `path` - string

Checks that a result exists in path. Returns 200 if it does, 400 if it doesn't. Polled by /list to check if a test is done

### list

Returns html with list of tests and lets you run them with a click, then polls /complete until it is done and shows a link to the result. 
This list is hardcoded and to work properly needs to be updated in code whenever the tests in DockerWright change.
/startone can be called on any test in DockerWright, even if the list is not updated.

### status

Parms:
- `job` - string

Returns the job info directly from Kubernetes. Job id is returned by /startone when starting a job.

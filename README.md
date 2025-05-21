# DOMINO-E User Simulator
# DockerWright
DockerWright is a set of tests for Playwright. All tests are under DockerWright/tests
See Playwright docs for how to write them. 

After any changes in the tests, rebuild DockerWright and make sure the image is available to DockerWrightManager

# DockerWrightManager

DockerWrightManager is a .NET web app that runs DockerWright images as jobs in Kubernetes and serves the test results.

## Relevant configuration keys - see appsettings.json for defaults and format

KubernetesHost: Kubernetes API url.
ImagePullSecret: Passed in the job spec.
Image: DockerWright image name. Passed in the job spec.
JobDefaultNamespace: Passed in the job spec.  
JobDefaultRequestMemory: Passed in the job spec.
JobDefaultRequestCPU: Passed in the job spec.

ResultVolume: Passed to the job and also used by the Manager. This is where the test results are stored and served from.    
URL: URL of this service. Used when generating links.
PageURL: URL of the UI being tested, passed to the actual tests as PLAYWRIGHT_PAGE_URL env variable
  
LogService: For error logging

## /api endpoints

### startjob 

Parms:
callback - string, optional

Runs the DockerWright image with "npm run test-html-report"
This runs every test in DockerWright/tests

If callback is specified, makes a HTTP GET request to callback when done

### startone

Parms:
test - string
callback - string, optional

Runs the DockerWright image with "npx playwright test {test} --browser=all --reporter=html"
This runs the specified test file (e.g. 'tests/test.spec.ts')
If callback is specified, makes a HTTP GET request to callback when done.
Returns job id.

### resultlist

Returns HTML with links to every test result currently stored in ResultVolume

### result

Parms:
path - string

Serves one test result as HTML. Links to this are listed by resultlist

### complete

Parms:
path - string

Checks that a result exists in path. Returns 200 if it does, 400 if it doesn't. Polled by /list to check if a test is done

### list

Returns html with list of tests and lets you run them with a click, then polls /complete until it is done and shows a link to the result. 
This list is hardcoded and to work properly needs to be updated in code whenever the tests in DockerWright change.
/startone can be called on any test in DockerWright, even if the list is not updated.

### status

Parms:
job - string

Returns the job info directly from Kubernetes. Job id is returned by /startone when starting a job.

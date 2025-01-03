using Microsoft.AspNetCore.Mvc;
using NimbusPulseAPI.Models;
using NimbusPulseAPI.Services;
using AutoMapper;
using NimbusPulseAPI.DTOs;

[Route("api/[controller]")]
[ApiController]
public class DeviceController : ControllerBase
{
    private readonly IDeviceService _deviceService;
    private readonly IMapper _mapper;

    public DeviceController(IDeviceService deviceService, IMapper mapper)
    {
        _deviceService = deviceService;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IActionResult> GetDevices()
    {
        var devices = await _deviceService.GetDevicesAsync();
        return Ok(devices);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetDeviceById(int id)
    {
        var device = await _deviceService.GetDeviceByIdAsync(id);
        if (device == null)
            return NotFound();

        return Ok(device);
    }

    [HttpPost]
    public async Task<IActionResult> AddDevice([FromBody] DeviceDTO deviceDto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var device = _mapper.Map<Device>(deviceDto);
        device.LastReportDate = DateTime.UtcNow;
        
        await _deviceService.AddDeviceAsync(device);
        return CreatedAtAction(nameof(GetDeviceById), new { id = device.Id }, device);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateDevice(int id, [FromBody] Device device)
    {
        if (id != device.Id)
            return BadRequest();

        await _deviceService.UpdateDeviceAsync(device);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteDevice(int id)
    {
        var device = await _deviceService.GetDeviceByIdAsync(id);
        if (device == null)
        {
            return NotFound("Device not found");
        }

        await _deviceService.DeleteDeviceAsync(device);
        return Ok("Device deleted successfully");
    }

    

    [HttpGet("order/{orderBy}")]
    public async Task<IActionResult> GetDevicesOrdered(string orderBy)
    {
        var devices = await _deviceService.GetDevicesOrderedAsync(orderBy);
        return Ok(devices);
    }

    [HttpPost("with-applications")]
    public async Task<IActionResult> AddDeviceWithApplications([FromBody] CreateDeviceWithAppsDTO deviceDto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var device = _mapper.Map<Device>(deviceDto);
        device.LastReportDate = DateTime.UtcNow;
        device.Applications = _mapper.Map<List<Application>>(deviceDto.Applications);

        await _deviceService.AddDeviceWithApplicationsAsync(device);
        return CreatedAtAction(nameof(GetDeviceById), new { id = device.Id }, device);
    }

    [HttpGet("details/{id}")]
    public async Task<IActionResult> GetDeviceDetails(int id)
    {
        var deviceDetails = await _deviceService.GetDeviceDetailsAsync(id);
        if (deviceDetails == null)
            return NotFound();

        return Ok(deviceDetails);
    }
}

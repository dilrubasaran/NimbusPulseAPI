using Microsoft.AspNetCore.Mvc;
using NimbusPulseAPI.Models;
using NimbusPulseAPI.Services;

[Route("api/[controller]")]
[ApiController]
public class DeviceController : ControllerBase
{
    private readonly IDeviceService _deviceService;

    public DeviceController(IDeviceService deviceService)
    {
        _deviceService = deviceService;
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
    public async Task<IActionResult> AddDevice([FromBody] Device device)
    {
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
    public async Task<IActionResult> DeleteDevice(Device id)
    {
        await _deviceService.DeleteDeviceAsync(id);
        return NoContent();
    }

    [HttpGet("order/{orderBy}")]
    public async Task<IActionResult> GetDevicesOrdered(string orderBy)
    {
        var devices = await _deviceService.GetDevicesOrderedAsync(orderBy);
        return Ok(devices);
    }
}
